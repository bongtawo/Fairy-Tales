using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour 
{
	public GameObject canvas;
	public GameObject wolf;
	public Renderer axeRender;
	public GameObject mainCamera;
	public GameObject vCamera;
	public PlayableDirector director;

	private void Start() 
	{
		Debug.Log("Start");
		canvas.SetActive(false);
		vCamera.SetActive(false);
		wolf.SetActive(false);
		//director.Stop();
	}

	private void OnTriggerEnter(Collider other) 
	{
		EventStart();
	}

	private void EventStart()
	{
		//mainCamera.SetActive(false);
		//axeRender.enabled = false;
		Debug.Log("Play");
		director.Play();
	}
}