using UnityEngine;
using System.Collections;

public class actionMenuIntro : MonoBehaviour {

	public Texture2D texturaFundo;
	public Texture2D texturaLogo;
	public Texture2D texturaGirl;

	private float larguraLogo = 200;
	private float alturaLogo = 120;
	private float larguraGirl = 280;
	private float alturaGirl = 250;

	private float larguraBotao = 160;
	private float alturaBotao = 40;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect(0,0,Screen.width, Screen.height), texturaFundo, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect(Screen.width - larguraLogo -10,10, larguraLogo,alturaLogo), texturaLogo, ScaleMode.StretchToFill);
		//GUI.DrawTexture (new Rect(10,Screen.height/2 - alturaGirl/2, larguraGirl, alturaGirl), texturaGirl, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect(10,Screen.height/2, larguraGirl, alturaGirl), texturaGirl, ScaleMode.StretchToFill);

		if(GUI.Button(new Rect(Screen.width/2-larguraBotao/2, Screen.height/2 + alturaBotao - 30, larguraBotao, alturaBotao), "Jogar COM Câmera"))
		{
			Application.LoadLevel ("MainAR");
		}

		if(GUI.Button(new Rect(Screen.width/2-larguraBotao/2, Screen.height/2 + alturaBotao + 30, larguraBotao, alturaBotao), "Jogar SEM Câmera"))
		{
			Application.LoadLevel ("Main");
		}
	}
}
