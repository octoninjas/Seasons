using UnityEngine;
using System.Collections;

public class GirlController : MonoBehaviour {

	private Animator anim;
	//private bool comecou = false;

	//public GameObject objetoCamera;
	//private CriaObjetos scriptB;

	public AudioSource somMusica;
	public AudioClip som1;
	public AudioClip som2;
	public AudioClip som3;
	public AudioClip som4;
	public AudioClip som5;
	public AudioClip som6;
	public AudioClip som7;
	public AudioClip som8;
	public AudioClip som9;
	public AudioClip som10;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		somMusica = GetComponent<AudioSource> ();
		//scriptB = (CriaObjetos)objetoCamera.GetComponent (typeof(CriaObjetos));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
//			if (comecou) {
				salta ();
//			} else {
//				this.gameObject.transform.position = new Vector3 (0.0f,0.0f,-2.5f);
//				this.gameObject.transform.localScale -= new Vector3 (0.1f,0.1f, 0.1f);
//				comecou = true;
//				salta ();
//			}
		}
	}

	void salta(){
		if (this.gameObject.transform.position.y <= 0.1) {
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 250, 0), ForceMode.Force);
			anim.SetInteger ("JumpParam", 1);
			Invoke ("stopAnim",0.3f);

			var sorteiaObjeto = Random.Range (1,11);
			switch (sorteiaObjeto) {
			case 1:
				somMusica.PlayOneShot (som1, 0.5f);
				break;
			case 2:
				somMusica.PlayOneShot (som2, 0.5f);
				break;
			case 3:
				somMusica.PlayOneShot (som3, 0.5f);
				break;
			case 4:
				somMusica.PlayOneShot (som4, 0.5f);
				break;
			case 5:
				somMusica.PlayOneShot (som5, 0.5f);
				break;
			case 6:
				somMusica.PlayOneShot (som6, 0.5f);
				break;
			case 7:
				somMusica.PlayOneShot (som7, 0.5f);
				break;
			case 8:
				somMusica.PlayOneShot (som8, 0.5f);
				break;
			case 9:
				somMusica.PlayOneShot (som9, 0.5f);
				break;
			case 10:
				somMusica.PlayOneShot (som10, 0.5f);
				break;
			default:
				break;
			}
		}
	}

	void stopAnim(){
		anim.SetInteger ("JumpParam", 0);
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Colisores"){
			//print ("GAME OVER!?!?!?!?");
			//scriptB.fimDeJogo();
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
