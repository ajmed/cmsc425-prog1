using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	private float rotationSpeed = 80.0f;
	private int rotationProbability = 750;
	private Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		targetRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0, 750) == 0) {
			if (Random.Range (0, 2) == 0) {
				targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
			} else {
				targetRotation *= Quaternion.AngleAxis(90, Vector3.up);
			}
		}
		transform.localRotation = Quaternion.RotateTowards (transform.localRotation, targetRotation, rotationSpeed * Time.deltaTime);
	}

}
