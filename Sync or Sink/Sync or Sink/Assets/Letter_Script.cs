using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Script : MonoBehaviour {
	public Sprite letterON;
	public Sprite letterOFF;
	public KeyCode letter;
	SpriteRenderer renderSprite;
	// Use this for initialization
	void Start () {
		renderSprite = GetComponent<SpriteRenderer>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (letter)){
			renderSprite.sprite = letterON;
			if (GameObject.Find("Bubble").transform.position == transform.position) {
				GameObject.Find ("Perfect").transform.position = transform.position;
			}
		};
		if (!(Input.GetKey (letter))||Input.GetKeyUp (letter)){
			renderSprite.sprite = letterOFF;
		};
	}
}
