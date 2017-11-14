using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour 
{
	public GameObject wolf;
	public Renderer axeRender;
	public GameObject mainCamera;
	public GameObject vCamera;
	public PlayableDirector director;

	private void Start() 
	{
		mainCamera.SetActive(true);
		vCamera.SetActive(false);
		wolf.SetActive(false);
		director.Stop();
	}

	private void Awake() 
	{
	}

	private void OnTriggerEnter(Collider other) 
	{
		
		mainCamera.SetActive(false);
		axeRender.enabled = false;
		wolf.SetActive(true);
		vCamera.SetActive(true);
		Debug.Log("Play");
		director.Play();
	}
}