using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;


public class NewBehaviourScript1 : MonoBehaviour {
    Text fpsText;
    		float fps = 0;
    int currentscore;
	// Use this for initialization
	void Start () {
        		fpsText = GetComponent<Text>();
		fpsText.text= ("" +fps);

	}
	
	// Update is called once per frame
	void Update () {
		fps = (1/Time.deltaTime);
		fpsText.text= ("" + fps);  
		Debug.Log ("" + fps);

	}
}
