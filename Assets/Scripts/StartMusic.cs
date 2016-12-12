using UnityEngine;
using System.Collections;

public class StartMusic : MonoBehaviour {

	private bool comecou = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {

			if (comecou == false) {
				this.GetComponent<AudioSource> ().Play ();
				comecou = true;
			}

		}
	}
}
