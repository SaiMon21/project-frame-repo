using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleText : MonoBehaviour {

	public Image titleText;
	public float fadeDurationStart;
	public float fadeDelay;
	public float fadeDurationEnd;

	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			playTitleFade ();
		}
	}


	public void playTitleFade(){
		Sequence titleSequence = DOTween.Sequence();

		titleSequence.Append(titleText.DOFade(0f,1f));
		titleSequence.Append(titleText.DOFade(1f,fadeDurationStart));
		titleSequence.Append(titleText.DOFade(1f,fadeDelay));
		titleSequence.Append(titleText.DOFade(0f,fadeDurationEnd));
	}
}
