using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleAppear : MonoBehaviour {
	public int bpmDefault;
	public int BPM;
	public float distance;
	private bool bpmSwitched = false;

	// Use this for initialization
	void Start () {
		BPM = bpmDefault;
		if((gameObject.transform.position.y)>=24){
			gameObject.SendMessage ("BPMChange", 4);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * BPM/480);
		distance = gameObject.transform.position.y - (-6);
		if (distance > 12&&distance<23) {
			Destroy (gameObject);
		}

	}

	void BPMChange (int newBPM) {
		if (bpmSwitched == false) {
			BPM = newBPM;
		}
			

	}
}
