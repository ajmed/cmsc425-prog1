using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerCircle : MonoBehaviour {

	public float reverseGravity = 75.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Marble")) {
			print ("The marble triggered the OnTriggerEvent when colliding with the WinnerCircle");
			other.gameObject.GetComponent<ConstantForce> ().force = new Vector3 (0.0f, reverseGravity, 0.0f);
		}
	}
}
