using UnityEngine;
using System.Collections;

public class ScrollChao : MonoBehaviour {


	private float scrollSpeed;
	public Renderer rend;

	// Use this for initialization
	void Start () {

		Time.timeScale = 1f;

		scrollSpeed = -0.3f;

		rend = GetComponent<Renderer>();

	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;

		rend.material.SetTextureOffset ("_MainTex", new Vector2(offset, 0));
	}
}
