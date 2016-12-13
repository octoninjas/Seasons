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

		if (Time.timeSinceLevelLoad >= 0f && Time.timeSinceLevelLoad <= 7f) {
			textoScore.text = dez;
		}
		if (Time.timeSinceLevelLoad >= 8f && Time.timeSinceLevelLoad <= 15f) {
			textoScore.text = jan;
		}
		if (Time.timeSinceLevelLoad >= 16f && Time.timeSinceLevelLoad <= 22f) {
			textoScore.text = fev;
		}
		if (Time.timeSinceLevelLoad >= 23f && Time.timeSinceLevelLoad <= 25f) {
			textoScore.text = mar;
		}
		if (Time.timeSinceLevelLoad >= 26f && Time.timeSinceLevelLoad <= 28f) {
			textoScore.text = abr;
		}
		if (Time.timeSinceLevelLoad >= 29f && Time.timeSinceLevelLoad <= 32f) {
			textoScore.text = mai;
		}
		if (Time.timeSinceLevelLoad >= 33f && Time.timeSinceLevelLoad <= 43f) {
			textoScore.text = jun;
		}
		if (Time.timeSinceLevelLoad >= 44f && Time.timeSinceLevelLoad <= 54f) {
			textoScore.text = jul;
		}
		if (Time.timeSinceLevelLoad >= 55f && Time.timeSinceLevelLoad <= 60f) {
			textoScore.text = ago;
		}
		if (Time.timeSinceLevelLoad >= 61f && Time.timeSinceLevelLoad <= 64f) {
			textoScore.text = set;
		}
		if (Time.timeSinceLevelLoad >= 65f && Time.timeSinceLevelLoad <= 68f) {
			textoScore.text = outu;
		}
		if (Time.timeSinceLevelLoad >= 69f && Time.timeSinceLevelLoad <= 72f) {
			textoScore.text = nov;
		}
		if (Time.timeSinceLevelLoad >= 73f && Time.timeSinceLevelLoad <= 83f) {
			textoScore.text = dez;
		}
		if (Time.timeSinceLevelLoad >= 84f && Time.timeSinceLevelLoad <= 94f) {
			textoScore.text = jan;
		}
		if (Time.timeSinceLevelLoad >= 95f && Time.timeSinceLevelLoad <= 105f) {
			textoScore.text = fev;
		}
		if (Time.timeSinceLevelLoad >= 106f && Time.timeSinceLevelLoad <= 116f) {
			textoScore.text = mar;
		}
		if (Time.timeSinceLevelLoad >= 117f && Time.timeSinceLevelLoad <= 127f) {
			textoScore.text = abr;
		}
		if (Time.timeSinceLevelLoad >= 128f && Time.timeSinceLevelLoad <= 138f) {
			textoScore.text = mai;
		}
		if (Time.timeSinceLevelLoad >= 139f && Time.timeSinceLevelLoad <= 149f) {
			textoScore.text = jun;
		}
		if (Time.timeSinceLevelLoad >= 150f && Time.timeSinceLevelLoad <= 160f) {
			textoScore.text = jul;
		}
		if (Time.timeSinceLevelLoad >= 161f && Time.timeSinceLevelLoad <= 171f) {
			textoScore.text = ago;
		}
		if (Time.timeSinceLevelLoad >= 172f && Time.timeSinceLevelLoad <= 182f) {
			textoScore.text = set;
		}
		if (Time.timeSinceLevelLoad >= 183f && Time.timeSinceLevelLoad <= 193f) {
			textoScore.text = outu;
		}
		if (Time.timeSinceLevelLoad >= 194f && Time.timeSinceLevelLoad <= 205f) {
			textoScore.text = nov;
		}
		if (Time.timeSinceLevelLoad >= 206f && Time.timeSinceLevelLoad <= 216f) {
			textoScore.text = dez;
		}
		if (Time.timeSinceLevelLoad >= 217f && Time.timeSinceLevelLoad <= 227f) {
			textoScore.text = jan;
		}
		if (Time.timeSinceLevelLoad >= 228f && Time.timeSinceLevelLoad <= 238f) {
			textoScore.text = fev;
		}
		if (Time.timeSinceLevelLoad >= 248f && Time.timeSinceLevelLoad <= 258f) {
			textoScore.text = mar;
		}
	}
}
