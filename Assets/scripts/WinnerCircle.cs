using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerCircle : MonoBehaviour {

	public float reverseGravity = 75.0f;
	public Text winText;

	// Use this for initialization
	void Start () {
		winText = GameObject.Find ("Win Text").GetComponent<Text> ();
		winText.text = "Collect the pick ups!";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Marble")) {
			if (other.gameObject.GetComponent<Marble> ().CanProceed ()) {
				winText.text = "Congratulations! You win!";
				other.gameObject.GetComponent<ConstantForce> ().force = new Vector3 (0.0f, reverseGravity, 0.0f);
			} else {
				winText.text = "You need to collect more pick ups to proceed to the next level!";
			}
		}
	}
}
