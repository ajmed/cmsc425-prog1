using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilter : MonoBehaviour {

	private float tiltAngle = 20.0f;
	private float smooth = 3.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		} else if (Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit ();
		}


		float tiltX = Input.GetAxis ("Vertical") * tiltAngle;
		float tiltZ = -Input.GetAxis ("Horizontal") * tiltAngle;

		Quaternion target = Quaternion.Euler (tiltX, 0, tiltZ);
		transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * smooth);
	}
}
