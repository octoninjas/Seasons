using UnityEngine;
using System.Collections;

public class CriaObjetos : MonoBehaviour {

	private float velocidadeObjeto = -75f;
	private float posicaoZInicialObjetos = 6f;
	private GameObject objetoX;
	private string estacao = "inverno";
	//private bool comecou = false;
	//private bool acabou = false;

	public Rigidbody rb;
	public GameObject nodeRootCena;
	public GameObject cerca;
	public GameObject rocha;
	public GameObject rocha3;
	public GameObject arbusto;
	public GameObject arbusto2;
	public GameObject nuvem;
	public GameObject relva1;
	public GameObject relva2;
	public GameObject relva3;
	public GameObject arvore;
	public GameObject arvore2;
	public GameObject arvoreOut;
	public GameObject arvoreInv1;
	public GameObject arvoreInv2;

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
		if (Time.timeSinceLevelLoad >= 24f &&  Time.timeSinceLevelLoad <= 29f) {
			estacao = "primavera";
		}

		if (Time.timeSinceLevelLoad >= 33f &&  Time.timeSinceLevelLoad <= 38f) {
			estacao = "verao";
		}

		if (Time.timeSinceLevelLoad >= 61f &&  Time.timeSinceLevelLoad <= 66f) {
			estacao = "outono";
		}

		if (Time.timeSinceLevelLoad >= 71f &&  Time.timeSinceLevelLoad <= 76f) {
			estacao = "inverno";
		}

		if (Time.timeSinceLevelLoad >= 106f &&  Time.timeSinceLevelLoad <= 111f) {
			estacao = "primavera";
		}

		if (Time.timeSinceLevelLoad >= 139f &&  Time.timeSinceLevelLoad <= 144f) {
			estacao = "verao";
		}

		if (Time.timeSinceLevelLoad >= 172f &&  Time.timeSinceLevelLoad <= 177f) {
			estacao = "outono";
		}

		if (Time.timeSinceLevelLoad >= 206f &&  Time.timeSinceLevelLoad <= 211f) {
			estacao = "inverno";
		}

		if (Time.timeSinceLevelLoad >= 248f &&  Time.timeSinceLevelLoad <= 253f) {
			estacao = "primavera";
		}
		print (estacao);
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

			if (estacao == "inverno") {
				GameObject novoObjeto = (GameObject)Instantiate (rocha3);
				novoObjeto.transform.parent = nodeRootCena.transform;
				novoObjeto.transform.position = new Vector3 (0, 0.19f, posicaoZInicialObjetos);
				novoObjeto.transform.rotation = Quaternion.Euler (0, 0, 0);
				novoObjeto.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, -100f), ForceMode.Force);
			} else {
				GameObject novoObjeto = (GameObject)Instantiate (rocha);
				novoObjeto.transform.parent = nodeRootCena.transform;
				novoObjeto.transform.position = new Vector3 (0, 0.19f, posicaoZInicialObjetos);
				novoObjeto.transform.rotation = Quaternion.Euler (-90, 0, 0);
				novoObjeto.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, -100f), ForceMode.Force);
			}

	}

	void criaObjeto(){
		var sorteiaObjeto = Random.Range (1,5);
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
			if (estacao == "inverno" || estacao == "outono") {
				objetoX = (GameObject)Instantiate (arbusto);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.localScale += new Vector3 (-0.2f, -0.2f, -0.2f);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
			}
			if (estacao == "primavera" || estacao == "verao") {
				objetoX = (GameObject)Instantiate (arbusto2);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.localScale += new Vector3 (-0.2f, -0.2f, -0.2f);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
			}
			break;

		case 2:
			objetoX = (GameObject)Instantiate (nuvem);
			objetoX.transform.parent = nodeRootCena.transform;
			objetoX.transform.position = new Vector3 (posicaoX, offSetNuvem, posicaoZInicialObjetos);
			objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
			break;

		case 3:
			if (estacao == "inverno" || estacao == "outono") {
				objetoX = (GameObject)Instantiate (relva3);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
			}
			if (estacao == "verao" || estacao == "primavera") {
				objetoX = (GameObject)Instantiate (relva2);
				objetoX.transform.parent = nodeRootCena.transform;
				objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
				objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
			}
			break;
		case 4:
			if (estacao == "inverno") {
				var sorteiaArvore = Random.Range (1, 4);
				if (sorteiaArvore == 1) {
					objetoX = (GameObject)Instantiate (arvoreInv1);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
				if (sorteiaArvore == 2) {
					objetoX = (GameObject)Instantiate (arvoreInv2);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
				if (sorteiaArvore == 3) {
					objetoX = (GameObject)Instantiate (arvore);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
			}

			if (estacao == "outono") {
				var sorteiaArvore = Random.Range (1, 3);
				if (sorteiaArvore == 1) {
					objetoX = (GameObject)Instantiate (arvoreOut);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
				if (sorteiaArvore == 2) {
					objetoX = (GameObject)Instantiate (arvore);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
			}

			if (estacao == "primavera" || estacao == "verao") {
				var sorteiaArvore = Random.Range (1, 3);
				if (sorteiaArvore == 1) {
					objetoX = (GameObject)Instantiate (arvore2);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
				if (sorteiaArvore == 2) {
					objetoX = (GameObject)Instantiate (arvore);
					objetoX.transform.parent = nodeRootCena.transform;
					objetoX.transform.position = new Vector3 (posicaoX, 0, posicaoZInicialObjetos);
					objetoX.transform.rotation = Quaternion.Euler (-90, giroRandom, 0);
				}
			}
		
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
