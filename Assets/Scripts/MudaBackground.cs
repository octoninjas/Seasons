// ping-pong animate background color
using UnityEngine;
using System.Collections;

public class MudaBackground : MonoBehaviour {
	public Color color1 = Color.green;
	public Color color2 = Color.white;
	public Color color3 = Color.blue;
	public float duration = 1000000.0F;

	Camera camera;

	void Start() {
		camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;
	}

	void Update() {
		if (Time.time >= 10f &&  Time.time <= 15f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color1, color2,  Mathf.PingPong(Time.time, 5));

		}
		if (Time.time >= 25f &&  Time.time <= 30f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color3, color2,  Mathf.PingPong(Time.time, 5));

		}

		//Debug.Log (Time.time);

	}
}