using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	private float rotationSpeed = 50.0f;

	void Update () {
		transform.Rotate (
			new Vector3(Time.deltaTime * rotationSpeed, 
				Time.deltaTime * rotationSpeed, 
				Time.deltaTime * rotationSpeed), 
			Space.World);
	}
}
