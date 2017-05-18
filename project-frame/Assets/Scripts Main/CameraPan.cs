using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraPan : MonoBehaviour {

	public DOTweenAnimation dtAnimObject;

	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			playCamPoint2 ();
			Debug.Log ("AAAAAAAAAAAAAAAAAAAAAAAAA");
		}
	}

	void OnTriggerExit(Collider player){
			playCamPoint1 ();
		Debug.Log ("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
	}


	public void playCamPoint2(){
		DOTween.Play ("camPoint2");
	}
		
	public void playCamPoint1(){
		DOTween.Play ("camPoint1");
	}
}
