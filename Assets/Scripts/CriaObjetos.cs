using UnityEngine;
using System.Collections;

public class CriaObjetos : MonoBehaviour {

	private float velocidadeObjeto = -75f;
	private float posicaoZInicialObjetos = 6f;
	private GameObject objetoX;
	//private bool comecou = false;
	//private bool acabou = false;

	public Rigidbody rb;
	public GameObject nodeRootCena;
	public GameObject cerca;
	public GameObject rocha;
	public GameObject arbusto;
	public GameObject nuvem;
	public GameObject relva1;
	public GameObject relva2;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

		InvokeRepeating ("criaCerca", 1, 0.54f);
		InvokeRepeating ("criaRocha", 1, 10.0f);
		InvokeRepeating ("criaObjeto", 1, 1.4f);

	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.anyKeyDown) {
//			comecou = true;
//		}
	}

	void OnGUI(){
		if (GUI.Button (new Rect (10, 10, 30, 30), "X")) {
			Application.LoadLevel ("MenuIntro");
		}
	}

	void criaCerca(){

			GameObject novoObjeto = (GameObject)Instantiate (cerca);
			novoObjeto.transform.parent = nodeRootCena.transform;
			novoObjeto.transform.position = new Vector3 (-2.5f, 0, posicaoZInicialObjetos);
			novoObjeto.transform.rotation = Quaternion.Euler (0, 180, 0);
			novoObjeto.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, velocidadeObjeto), ForceMode.Force);

		}

	void criaRocha(){

			var offsetRocha = Random.Range (-0.5f, 0.0f);
			GameObject novoObjeto = (GameObject)Instantiate (rocha);
			novoObjeto.transform.parent = nodeRootCena.transform;
			novoObjeto.transform.position = new Vector3 (0, 0.19f, posicaoZInicialObjetos);
			novoObjeto.transform.rotation = Quaternion.Euler (-90, 0, 0);
			novoObjeto.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, -100f), ForceMode.Force);

	}

	void criaObjeto(){
		var sorteiaObjeto = Random.Range (1,4);
		var offSetNuvem = Random.Range (2.5f,3.5f);
		var giroRandom = Random.Range (-180f,180f);
		var giroNuvem = 0.0f;
		var posicaoX = 0.0f;

		if ((Random.Range (1, 3) % 2) == 0) {
			posicaoX = -1.6f;
			giroNuvem = 0.0f;
		} else {
			posicaoX = 1.9f;
			giroNuvem = 180f;
		}

			switch (sorteiaObjeto) {
			case 1:
				objetoX = (GameObject)Instantiate (arbusto);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.localScale += new Vector3 (-0.2f, -0.2f, -0.2f);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				break;

			case 2:
				objetoX = (GameObject)Instantiate (nuvem);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, offSetNuvem, posicaoZInicialObjetos);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				break;

			case 3:
				objetoX = (GameObject)Instantiate (relva2);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				break;

			default:
				break;
			}

			objetoX.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, velocidadeObjeto), ForceMode.Force);

	}

//	public void fimDeJogo(){
//		if (!acabou) {
//			acabou = true;
//			print ("Game Over");
//			comecou = false;
//		}
//	}
}
