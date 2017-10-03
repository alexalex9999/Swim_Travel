using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyWait : MonoBehaviour {
	private int FrameCount = 0;
	private int startFrame;
	public Animation anim;
	public AnimationClip animClip;
	// Use this for initialization
	void Start () {
		startFrame = FrameCount;
//		animClip = anim.GetClip ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y > 1.5) {
			if (FrameCount - startFrame > 30) {
				GameObject.Destroy (gameObject);
			}
		}
		FrameCount++;
	}
}
