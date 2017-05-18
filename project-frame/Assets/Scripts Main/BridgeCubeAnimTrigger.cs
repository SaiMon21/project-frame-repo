using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCubeAnimTrigger : MonoBehaviour {

	public Animator bridgeCubeAnim;

	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			bridgeCubeAnim.Play ("BridgeCubeDoor");
			destroyBridgeCubeTrigger ();
		}
			
	}
		

	public void destroyBridgeCubeTrigger(){
		Destroy (gameObject);
	}


}
