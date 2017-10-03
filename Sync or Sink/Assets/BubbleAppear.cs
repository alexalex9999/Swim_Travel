using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleAppear : MonoBehaviour {
	public int bpmDefault;
	public int BPM;
	public GameObject Perfect;
	public float distance;
	private bool bpmSwitched = false;
	private Vector3 positionD = new Vector3 (-10.5f,3.5f,0);
	private Vector3 positionF = new Vector3 (-8.6f,3.5f,0);
	private Vector3 positionJ = new Vector3 (-6.8f,3.5f,0);
	private Vector3 positionK = new Vector3 (-4.85f,3.5f,0);
	public float absoluteDistanceValue;

	// Use this for initialization
	void Start () {
		BPM = bpmDefault;

		//if((gameObject.transform.position.y)>=24){
		//	gameObject.SendMessage ("BPMChange", 4);
	//	}

	}
	public void bpmDefaultChange(string bpmchange){
		bpmDefault = int.Parse(bpmchange);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * BPM/100);
		distance = gameObject.transform.position.y - (-6);
		if (distance > 12&&distance<23) {
			Destroy (gameObject);
		}
		absoluteDistanceValue = (Mathf.Abs ( 4f - gameObject.transform.position.y ));
		if (absoluteDistanceValue <= (float).25) {
			if (Input.GetKey (KeyCode.D) && gameObject.transform.position.x == -10.5f) {
				SendMessage ("letterPressPerfect", KeyCode.D);
			}
			if (Input.GetKey (KeyCode.F) && gameObject.transform.position.x == -8.6f) {
				SendMessage ("letterPressPerfect", KeyCode.F);
			}
			if (Input.GetKey (KeyCode.J) && gameObject.transform.position.x == -6.8f) {
				SendMessage ("letterPressPerfect", KeyCode.J);
			}

			if (Input.GetKey (KeyCode.K) && gameObject.transform.position.x == -4.85f) {
				SendMessage ("letterPressPerfect", KeyCode.J);
			}
		} else if (absoluteDistanceValue > .25 && absoluteDistanceValue < 5) {
			if (Input.GetKey (KeyCode.D) && gameObject.transform.position.x == -10.5f) {
				SendMessage ("letterPressPerfect", KeyCode.D);
			}
			if (Input.GetKey (KeyCode.F) && gameObject.transform.position.x == -8.6f) {
				SendMessage ("letterPressPerfect", KeyCode.F);
			}

			if (Input.GetKey (KeyCode.J) && gameObject.transform.position.x == -6.8f) {
				SendMessage ("letterPressPerfect", KeyCode.J);
			}

			if (Input.GetKey (KeyCode.K) && gameObject.transform.position.x == -4.85f) {
				SendMessage ("letterPressPerfect", KeyCode.J);
			}
		}
	}

	public void BPMChange (int newBPM) {
		if (!bpmSwitched) {
			BPM = newBPM;
			bpmSwitched = true;
		}
		}
			
	public void letterPressPerfect (KeyCode key){
		if (absoluteDistanceValue <= .25) {
			if (key == KeyCode.D) {
				GameObject perfect = (GameObject)Instantiate (Perfect, gameObject.transform.position, transform.rotation);
				GameObject.Destroy (gameObject);
			}
			if (key == KeyCode.F) {
				GameObject perfect = (GameObject)Instantiate (Perfect, gameObject.transform.position, transform.rotation);
				GameObject.Destroy (gameObject);

			}
			if (key == KeyCode.J) {
				GameObject perfect = (GameObject)Instantiate (Perfect, gameObject.transform.position, transform.rotation);
				GameObject.Destroy (gameObject);

			}
			if (key == KeyCode.K) {
				GameObject perfect = (GameObject)Instantiate (Perfect, gameObject.transform.position, transform.rotation);
				GameObject.Destroy (gameObject);

			}
		}
	}
}
