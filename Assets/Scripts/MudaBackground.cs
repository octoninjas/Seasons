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
		if (Time.timeSinceLevelLoad >= 24f &&  Time.timeSinceLevelLoad <= 29f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 33f &&  Time.timeSinceLevelLoad <= 38f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color1, color2,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 61f &&  Time.timeSinceLevelLoad <= 66f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color2, color3,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 71f &&  Time.timeSinceLevelLoad <= 76f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color3, color4,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 106f &&  Time.timeSinceLevelLoad <= 111f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 139f &&  Time.timeSinceLevelLoad <= 144f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color1, color2,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 172f &&  Time.timeSinceLevelLoad <= 177f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color2, color3,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 206f &&  Time.timeSinceLevelLoad <= 211f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color3, color4,  Mathf.PingPong(Time.time, 5));
		}

		if (Time.timeSinceLevelLoad >= 248f &&  Time.timeSinceLevelLoad <= 253f) {
			//float t = Mathf.PingPong (Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp (color4, color1,  Mathf.PingPong(Time.time, 5));
		}

		//Debug.Log (Time.time);

	}
}