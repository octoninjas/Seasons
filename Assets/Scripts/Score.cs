using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

//	private string meses = new string[] {
//		"Janeiro",
//		"Fevereiro",
//		"Março",
//		"Abril",
//		"Maio",
//		"Junho",
//		"Julho",
//		"Agosto",
//		"Setembro",
//		"Outubro",
//		"Novembro",
//		"Dezembro"
//	};

	private string jan = "Janeiro";
	private string fev = "Fevereiro";
	private string mar = "Março";
	private string abr = "Abril";
	private string mai = "Maio";
	private string jun = "Junho";
	private string jul = "Julho";
	private string ago = "Agosto";
	private string set = "Setembro";
	private string outu = "Outubro";
	private string nov = "Novembro";
	private string dez = "Dezembro";

	public GUIText textoScore;
	private string score;
	private bool comecou = false;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= 0f && Time.time <= 7f) {
			textoScore.text = dez;
		}
		if (Time.time >= 8f && Time.time <= 15f) {
			textoScore.text = jan;
		}
		if (Time.time >= 16f && Time.time <= 22f) {
			textoScore.text = fev;
		}
		if (Time.time >= 23f && Time.time <= 25f) {
			textoScore.text = mar;
		}
		if (Time.time >= 26f && Time.time <= 28f) {
			textoScore.text = abr;
		}
		if (Time.time >= 29f && Time.time <= 32f) {
			textoScore.text = mai;
		}
		if (Time.time >= 33f && Time.time <= 43f) {
			textoScore.text = jun;
		}
		if (Time.time >= 44f && Time.time <= 54f) {
			textoScore.text = jul;
		}
		if (Time.time >= 55f && Time.time <= 60f) {
			textoScore.text = ago;
		}
		if (Time.time >= 61f && Time.time <= 64f) {
			textoScore.text = set;
		}
		if (Time.time >= 65f && Time.time <= 68f) {
			textoScore.text = outu;
		}
		if (Time.time >= 69f && Time.time <= 72f) {
			textoScore.text = nov;
		}
		if (Time.time >= 73f && Time.time <= 83f) {
			textoScore.text = dez;
		}
		if (Time.time >= 84f && Time.time <= 94f) {
			textoScore.text = jan;
		}
		if (Time.time >= 95f && Time.time <= 105f) {
			textoScore.text = fev;
		}
		if (Time.time >= 106f && Time.time <= 116f) {
			textoScore.text = mar;
		}
		if (Time.time >= 117f && Time.time <= 127f) {
			textoScore.text = abr;
		}
		if (Time.time >= 128f && Time.time <= 138f) {
			textoScore.text = mai;
		}
		if (Time.time >= 139f && Time.time <= 149f) {
			textoScore.text = jun;
		}
		if (Time.time >= 150f && Time.time <= 160f) {
			textoScore.text = jul;
		}
		if (Time.time >= 161f && Time.time <= 171f) {
			textoScore.text = ago;
		}
		if (Time.time >= 172f && Time.time <= 182f) {
			textoScore.text = set;
		}
		if (Time.time >= 183f && Time.time <= 193f) {
			textoScore.text = outu;
		}
		if (Time.time >= 194f && Time.time <= 205f) {
			textoScore.text = nov;
		}
		if (Time.time >= 206f && Time.time <= 216f) {
			textoScore.text = dez;
		}
		if (Time.time >= 217f && Time.time <= 227f) {
			textoScore.text = jan;
		}
		if (Time.time >= 228f && Time.time <= 238f) {
			textoScore.text = fev;
		}
		if (Time.time >= 248f && Time.time <= 258f) {
			textoScore.text = mar;
		}
	}
}
