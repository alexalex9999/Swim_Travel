using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawning : MonoBehaviour {

	public GameObject Bubble;
	// Use this for initialization
	public Vector3 positionD;
	public Vector3 positionF;
	public Vector3 positionJ;
	public Vector3 positionK;
	void Start () {
		positionD = new Vector3 (-10.5f,-6f,0);
		positionF = new Vector3 (-8.7f,-6f,0);
		positionJ = new Vector3 (-6.8f,-6f,0);
		positionK = new Vector3 (-4.85f,-6f,0);

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void letter (string letter) {
		if(letter=="d"){
			GameObject bubble = (GameObject)Instantiate (Bubble, positionD,transform.rotation);
				}
		if(letter=="f"){
			GameObject bubble = (GameObject)Instantiate (Bubble, positionF,transform.rotation);
				}
		if(letter=="j"){
			GameObject bubble = (GameObject)Instantiate (Bubble, positionJ,transform.rotation);
		}
		if(letter=="k"){
			GameObject bubble = (GameObject)Instantiate (Bubble, positionK,transform.rotation);
		}
	}
}
