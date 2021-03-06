using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class rotateApartment : MonoBehaviour {


	public Transform apartment;
	public Image buttonPrompt;
	public float rotationTime;
	public float lockTimer;
	public float timerMax;
	public bool lockOn;
	public bool playerInRange;


	void Start(){
		lockOn = false;
		playerInRange = false;
		lockTimer = 0;
	}


	void OnTriggerEnter(Collider player){
		if (player.tag == "Player" && !lockOn) {
			playerInRange = true;
			//buttonPrompt.DOFade (1, 0.5f);
		}
	}


	void OnTriggerExit(Collider player){
			playerInRange = false;
		buttonPrompt.DOFade (0, 0.3f);
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.E) && !lockOn && playerInRange) {
			apartment.DOLocalRotate (new Vector3 (0, 90f, 0), rotationTime, RotateMode.LocalAxisAdd);
			lockTimer = timerMax;

		}

		if (Input.GetKeyDown (KeyCode.Q) && !lockOn && playerInRange) {
			apartment.DOLocalRotate (new Vector3 (0, -90f, 0), rotationTime, RotateMode.LocalAxisAdd);
			lockTimer = timerMax;
		}


		if (lockTimer > 0) {
			lockOn = true;
			lockTimer -= 1f * Time.deltaTime;
			buttonPrompt.DOFade (0, 0.3f);
		}

		if (lockTimer <0) {
			lockOn = false;
			lockTimer = 0;
		}


		if (playerInRange && !lockOn) {
			buttonPrompt.DOFade (1, 0.3f);
		}

	}









// ================================================================================

//	public float smooth = 1f;
//	private Quaternion targetRotation;
//
//	void Start(){
//		targetRotation = transform.rotation;
//	}
//
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.E)) { 
//			targetRotation *=  Quaternion.AngleAxis(90, Vector3.up);
//		}
//
//
//		if (Input.GetKeyDown (KeyCode.Q)) { 
//			targetRotation *=  Quaternion.AngleAxis(-90, Vector3.up);
//		}
//
//		transform.rotation= Quaternion.Lerp (transform.rotation, targetRotation , 10 * smooth * Time.deltaTime); 
//	}



// ================================================================================

//	IEnumerator RotateMe(Vector3 byAngles, float inTime) 
//	{   var fromAngle = transform.rotation;
//		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
//		for(var t = 0f; t < 1; t += Time.deltaTime/inTime) {
//			transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
//			yield return null;
//		}
//	}
//	void Update () {
//		if(Input.GetKeyDown(KeyCode.E)){
//			StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));
//		}
//		if(Input.GetKeyDown(KeyCode.Q)){
//			StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
//		}
//	}
//



}



