using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeveloperName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		pauseNameTween ();
	}


	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			DOTween.Play ("DeveloperFadeIn");
		}
	}



	public void pauseNameTween(){
		DOTween.Pause ("DeveloperFadeIn");
	}
	

}
