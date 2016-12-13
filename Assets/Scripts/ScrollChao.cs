using UnityEngine;
using System.Collections;

public class ScrollChao : MonoBehaviour {


	private float scrollSpeed;
	public Renderer rend;
	public Texture tex1;
	public Texture tex2;
	public Texture tex3;
	public Texture tex4;

	// Use this for initialization
	void Start () {

		Time.timeScale = 1f;

		scrollSpeed = -0.2f;

		rend = GetComponent<Renderer>();

	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;

		rend.material.SetTextureOffset ("_MainTex", new Vector2(offset, 0));

		if (Time.timeSinceLevelLoad >= 24f &&  Time.timeSinceLevelLoad <= 29f) {
			rend.material.SetTexture ("_MainTex", tex2);
		}

		if (Time.timeSinceLevelLoad >= 33f &&  Time.timeSinceLevelLoad <= 38f) {
			rend.material.SetTexture ("_MainTex", tex3);
		}

		if (Time.timeSinceLevelLoad >= 61f &&  Time.timeSinceLevelLoad <= 66f) {
			rend.material.SetTexture ("_MainTex", tex4);
		}

		if (Time.timeSinceLevelLoad >= 71f &&  Time.timeSinceLevelLoad <= 76f) {
			rend.material.SetTexture ("_MainTex", tex1);
		}

		if (Time.timeSinceLevelLoad >= 106f &&  Time.timeSinceLevelLoad <= 111f) {
			rend.material.SetTexture ("_MainTex", tex2);
		}

		if (Time.timeSinceLevelLoad >= 139f &&  Time.timeSinceLevelLoad <= 144f) {
			rend.material.SetTexture ("_MainTex", tex3);
		}

		if (Time.timeSinceLevelLoad >= 172f &&  Time.timeSinceLevelLoad <= 177f) {
			rend.material.SetTexture ("_MainTex", tex4);
		}

		if (Time.timeSinceLevelLoad >= 206f &&  Time.timeSinceLevelLoad <= 211f) {
			rend.material.SetTexture ("_MainTex", tex1);
		}

		if (Time.timeSinceLevelLoad >= 248f &&  Time.timeSinceLevelLoad <= 253f) {
			rend.material.SetTexture ("_MainTex", tex2);
		}

	}
}
