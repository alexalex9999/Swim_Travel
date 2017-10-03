using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[RequireComponent(typeof(AudioSource))]
public class ReadBubbleFile : MonoBehaviour {
	
	public string bubbleFileName;
	public AudioSource bubbleSong = GetComponent<AudioSource>;
	public AudioClip bubbleClip;
	public string[] bubbleTrack;
	public int[] bpmTrack;
	public int FrameCount = 0;
	public string[] currentKeys;

	// Use this for initialization
	void Start () {
		
		var fileReader = new StreamReader (Application.dataPath + "/" + bubbleFileName + ".txt");
		var fileContents = fileReader.ReadToEnd();
		fileReader.Close ();

		var linesOld = fileContents.Split ("\n"[0]);
		string[] lines = new string[linesOld.Length-1];
		var lastLine = linesOld[linesOld.Length-1].Split (" " [0]);
		var firstLine = linesOld [0].Split("," [0]);
		Debug.Log (firstLine [0]);
		Debug.Log (firstLine [1]);
		BroadcastMessage ("bpmDefaultChange", firstLine[1]);
		bubbleClip = Resources.Load (firstLine[0]) as AudioClip;
		bubbleSong.clip = bubbleClip;
		for (int q = 0; q < linesOld.Length-1; q++) {
			lines [q] = linesOld [q + 1];
		}
		//bubbleSong = 
		float length = float.Parse(lastLine [0]) * 30;
		bubbleTrack = new string[(int) length];
		bpmTrack = new int[(int) length];


		for (int a = 0; a < bubbleTrack.Length; a++) {
			bubbleTrack [a] = a + " null";
			//bpmTrack[a] = 0;
			for (int k = 0; k < lines.Length; k++) {
				string[] split = lines [k].Split(" " [0]);
				float lengthAgain = (float.Parse (split [0]) * 30);
				if ( (int) lengthAgain-1 == a) {
					bubbleTrack [a] = (a + " " + split [1]);

				//	if (split.Length == 3) {
				//		bpmTrack[a] = ((int) float.Parse (split[2]));
				//	}

				}
			}
		}

		bubbleSong.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		FrameCount++;
		if(FrameCount<bubbleTrack.Length){
			
			if(!(bpmTrack[FrameCount]==0)){
			gameObject.BroadcastMessage ("BPMChange", bpmTrack[FrameCount]);
				Debug.Log ("its chagnign bBPM");
			}
			//try{
				Debug.Log("bubble" + bubbleTrack[FrameCount]);
			string[] Keys = bubbleTrack[FrameCount].Split(" " [0]);
				Debug.Log("keys " + Keys.Length);
			if(!(Keys[1]=="null")){
			string[] KeysMoreSplit = Keys [1].Split ("," [0]);
			currentKeys = new string[KeysMoreSplit.Length];
			for (int p = 0; p < KeysMoreSplit.Length; p++) {
				currentKeys [p] = (KeysMoreSplit [p]).Trim ();
			}
			int test = currentKeys.Length;
				for (int j = currentKeys.Length - 1; j >= 0; j--) {

					if (currentKeys [j] == "d") {
						gameObject.BroadcastMessage ("letter", "d");
					}
					if (currentKeys [j] == "f") {
						gameObject.BroadcastMessage ("letter", "f");
					}
					if (currentKeys [j] == "j") {
						gameObject.BroadcastMessage ("letter", "j");
					}
					if (currentKeys [j] == "k") {
						gameObject.BroadcastMessage ("letter", "k");
					}
				}			
		}
		//	}catch(Exception overflow) {
				
		//	} 
		}
}

}
