using UnityEngine;
using System.Collections;

public class actionMenuOver : MonoBehaviour {

	public Texture2D texturaFundo;

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