using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marble : MonoBehaviour {

	private float jumpForce = 200.0f;
	private int pickUpCount = 0;
	private int requiredPickUpCount = 2;
	private Text countText;
	private Text winText;

	// Use this for initialization
	void Start () {
		countText = GameObject.Find ("Count Text").GetComponent<Text> ();
		winText = GameObject.Find ("Win Text").GetComponent<Text> ();
		countText.text = "Pick Up Count: " + pickUpCount + " out of " + requiredPickUpCount;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.AddForce (Vector3.up * jumpForce);
		}

		if (transform.position.y < -20) {
			winText.text = "YOU LOSE! GAME OVER MAN!";
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			pickUpCount++;
			countText.text = "Pick Up Count: " + pickUpCount + " out of " + requiredPickUpCount;
			if (CanProceed ()) {
				countText.text = "Head to the winner's circle to proceed to the next level!";
			}
			other.gameObject.SetActive (false);
		}
	}

	public bool CanProceed() {
		return pickUpCount >= requiredPickUpCount;
	}
}
