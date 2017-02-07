using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float maxCameraDistance = 50f;
	public float minCameraDistance = 5f;
	public float cameraDistance = 10f;
	public float scrollSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		cameraDistance += Input.GetAxis ("Mouse ScrollWheel") * scrollSpeed;
		cameraDistance = Mathf.Clamp (cameraDistance, minCameraDistance, maxCameraDistance);

		float cameraComponent = Mathf.Sqrt ( (cameraDistance * cameraDistance) / 3);
		transform.position = new Vector3 (cameraComponent, cameraComponent, cameraComponent);
	}
}
