using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayZoneGenerator : MonoBehaviour {

	private int xTicks;
	private int zTicks;
	private float xTickSize; // multiply tick by ratio to get coordinate position
	private float zTickSize; // multiply tick by ratio to get coordinate position
	private int xCenter;
	private int zCenter;

	private GameObject wallParent;
	private GameObject wall;

	private GameObject pickUpParent;
	private GameObject pickUp;
	private HashSet<string> pickUpPositions;
	private Quaternion[] startingAngles;

	private GameObject platform;


	// Use this for initialization
	void Start () {
		platform = GameObject.Find ("Platform");

		wallParent = GameObject.Find ("Walls");
		wall = (GameObject)Resources.Load ("Wall");

		pickUpParent = GameObject.Find ("PickUps");
		pickUp = (GameObject)Resources.Load ("PickUp");
		pickUpPositions = new HashSet<string> ();

		startingAngles = new Quaternion[4] {Quaternion.AngleAxis(0, Vector3.up), 
			Quaternion.AngleAxis(90, Vector3.up), 
			Quaternion.AngleAxis(180, Vector3.up), 
			Quaternion.AngleAxis(270, Vector3.up)};

		xTicks = 21;
		zTicks = 21;
		xTickSize = platform.transform.localScale.x / xTicks;
		zTickSize = platform.transform.localScale.z / zTicks;

		int[] randos = new int[] {-7, -5, -3, 3, 5, 7};
		int ri = 1;
		int rj = 1;
		while (pickUpPositions.Count < 6) {
			ri = randos[Random.Range (0, randos.Length)];
			rj = randos[Random.Range (0, randos.Length)];
			pickUpPositions.Add("" + ri + ":" + rj);
		}

		for (int i = -8; i <= 8; i++) {
			for (int j = -8; j <= 8; j++) {
				if (i%2 == 0 && j%2 == 0 && Random.Range(0,4) < 3 && Mathf.Abs(i) > 1 && Mathf.Abs(j) > 1) {
					Instantiate (wall, new Vector3(i, 0.0f, j), startingAngles[Random.Range(0,4)], wallParent.transform);
				}
				if (pickUpPositions.Contains ("" + i + ":" + j) && Mathf.Abs(i) > 1 && Mathf.Abs(j) > 1) {
					Instantiate (pickUp, new Vector3(i, 0.5f, j), Quaternion.identity, pickUpParent.transform);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
