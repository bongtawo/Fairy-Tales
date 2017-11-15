using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour 
{
	public GameObject wolf;
	public Renderer axeRender;
	public PlayableDirector director;

	private void Start() 
	{
		Debug.Log("Start");
		wolf.SetActive(false);
		director.Stop();
	}

	private void OnTriggerEnter(Collider other) 
	{
		EventStart();
	}

	private void EventStart()
	{
		axeRender.enabled = false;
		Debug.Log("Play");
		director.Play();
	}
}