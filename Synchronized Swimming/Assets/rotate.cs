using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

using UnityEngine;

public class rotate : MonoBehaviour {

	int timeHeld= 0;
	int speedNo = 0;
	float speedMore = 0; 
	bool slowDown = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKeyUp(KeyCode.LeftArrow))
		//	timeHeld = 0;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			timeHeld++;
			transform.Rotate (Vector3.forward * (float) Math.Sqrt(timeHeld)*100 * (Time.deltaTime));
			slowDown = true;
		}

		if ((Input.GetKeyUp (KeyCode.LeftArrow))||!(Input.GetKey (KeyCode.LeftArrow))) {

			if (slowDown == true) {
				speedNo = 0;
				transform.Rotate (Vector3.forward * (float) Math.Sqrt(timeHeld)*100 * (Time.deltaTime));
				timeHeld -= 2;
				speedMore = timeHeld * 100;
				Debug.Log ("SLOW DOWN");
				if (timeHeld < 0 || timeHeld == 0) {
					slowDown = false;
					timeHeld = 0;
				}

			}
		}
	}
}
