using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour {

	public float lockXRotate = -90.0f;
	public float lockYRotate = 0.0f;
	public float lockZRotate = -90.0f;

	void Update () {
		transform.rotation = Quaternion.Euler (lockXRotate, lockYRotate, lockZRotate);
	}
}
