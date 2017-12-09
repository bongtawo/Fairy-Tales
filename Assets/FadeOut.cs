using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public AudioSource bgm;
	public Animator animator;

	private void OnEnable() {
		
		StartCoroutine("FadeOutBGM");
	}

	IEnumerator FadeOutBGM()
	{
		animator.SetTrigger("Walk");
		
		for(float i = 0.001f; bgm.volume > 0; i+=0.001f)
		{
			bgm.volume -= i;
			yield return new WaitForSeconds(0.1f);			
		}
	}
}
