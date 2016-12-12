using UnityEngine;
using System.Collections;

public class GirlController : MonoBehaviour {

	private Animator anim;
	private bool comecou = false;

	public GameObject objetoCamera;
	private CriaObjetos scriptB;


	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();

		scriptB = (CriaObjetos)objetoCamera.GetComponent (typeof(CriaObjetos));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			if (comecou) {
				salta ();
			} else {
				this.gameObject.transform.position = new Vector3 (0.0f,0.0f,-2.5f);
				this.gameObject.transform.localScale -= new Vector3 (0.1f,0.1f, 0.1f);
				comecou = true;
				salta ();
			}
		}
	}

	void salta(){
		if (this.gameObject.transform.position.y <= 0.1) {
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 250, 0), ForceMode.Force);
			anim.SetInteger ("JumpParam", 1);
			Invoke ("stopAnim",0.3f);
		}
	}

	void stopAnim(){
		anim.SetInteger ("JumpParam", 0);
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Colisores"){
			//print ("GAME OVER!?!?!?!?");
			scriptB.fimDeJogo();
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (-250, 2500, -2500), ForceMode.Force);

		}
	}

//	void apagaTodosObjetos(){
//		var gameObjects = GameObject.FindGameObjectsWithTag ("OBJETOS");
//		for(var i=0; i<gameObjects.Length; i++){
//			Destroy (gameObjects [i]);
//		}
//		girl.transform.position = new Vector3 ();
//		comecou = true;
//		acabou = false;
//		podeReiniciar = false;
//		salta ();
//	}
}
