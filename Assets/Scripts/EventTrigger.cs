using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour
{
    public GameObject animal;
    public Renderer axeRender;
    public PlayableDirector director;

    private void Start()
    {
        animal.SetActive(false);
        director.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        EventStart();
    }

    private void EventStart()
    {
        //axeRender.enabled = false;
        Debug.Log("Play");
        director.Play();
    }
}