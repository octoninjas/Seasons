// ping-pong animate background color
using UnityEngine;
using System.Collections;

public class MudaBackground : MonoBehaviour {
	public Color color1 = new Color(124,252,0);
	public Color color2 = new Color(255,160,122);
	public Color color3 = new Color(160,82,45);
	public Color color4 = new Color(176,224,230);
	public float duration = 1000000.0F;

	Camera camera;

	void Start() {
		camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;
	}

	void Update() {
		if (Time.time >= 24f &&  Time.time <= 29f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));

		}
		if (Time.time >= 33f &&  Time.time <= 38f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color1, color2,  Mathf.PingPong(Time.time, 5));

		}
		if (Time.time >= 61f &&  Time.time <= 66f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color2, color3,  Mathf.PingPong(Time.time, 5));
		}
		if (Time.time >= 71f &&  Time.time <= 76f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color3, color4,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.time >= 106f &&  Time.time <= 111f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));
		}
		if (Time.time >= 139f &&  Time.time <= 144f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color1, color2,  Mathf.PingPong(Time.time, 5));
		}
		if (Time.time >= 172f &&  Time.time <= 177f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color2, color3,  Mathf.PingPong(Time.time, 5));
		}
		if (Time.time >= 206f &&  Time.time <= 211f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color3, color4,  Mathf.PingPong(Time.time, 5));
		}
		if (Time.time >= 248f &&  Time.time <= 253f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));
		}

		//Debug.Log (Time.time);

	}
}