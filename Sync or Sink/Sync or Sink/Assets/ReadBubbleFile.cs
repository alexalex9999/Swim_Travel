using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[RequireComponent(typeof(AudioSource))]
public class ReadBubbleFile : MonoBehaviour {
	
	public string bubbleFileName;
	public AudioSource bubbleSong;
	public string[] bubbleTrack;
	public int[] bpmTrack;
	public int FrameCount = 0;
	public string[] currentKeys;

	// Use this for initialization
	void Start () {
		
		var fileReader = new StreamReader (Application.dataPath + "/" + bubbleFileName + ".txt");
		var fileContents = fileReader.ReadToEnd();
		fileReader.Close ();

		var lines = fileContents.Split ("\n"[0]);

		var lastLine = lines[lines.Length-1].Split (" "[0]);
		float length = float.Parse(lastLine [0]) * 30;
		bubbleTrack = new string[(int) length];
		bpmTrack = new int[(int) length];


		for (int a = 0; a < bubbleTrack.Length; a++) {
			bubbleTrack [a] = a + " ";
			bpmTrack[a] = 0;
			for (int k = 0; k < lines.Length; k++) {
				string[] split = lines [k].Split(" " [0]);
				float lengthAgain = (float.Parse (split [0]) * 30);
				if ( (int) lengthAgain-1 == a) {
					bubbleTrack [a] = (a + " " + split [1]);
					if (split.Length == 3) {
						bpmTrack[a] = ((int) int.Parse (split[2]));
					}

				}
			}
		}

		bubbleSong.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if(FrameCount<bubbleTrack.Length){
			FrameCount++;
			if(!(bpmTrack[FrameCount]==0)){
			gameObject.BroadcastMessage ("BPMChange", bpmTrack[FrameCount]);
			}
		string[] Keys = bubbleTrack[FrameCount].Split(" " [0]);
			string[] KeysMoreSplit = Keys [1].Split ("," [0]);
			currentKeys = new string[KeysMoreSplit.Length];
			for (int p = 0; p < KeysMoreSplit.Length; p++) {
				currentKeys [p] = (KeysMoreSplit [p]).Trim ();;
			}
			int test = currentKeys.Length;
			for (int j = currentKeys.Length-1; j >= 0; j--) {

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
}

}
