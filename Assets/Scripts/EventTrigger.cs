using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour
{
    public GameObject animal;
    public Renderer axeRender;
    public PlayableDirector director;
    public GameObject player;
    public Vector3 aniStartPos;

    private void Start()
    {
        animal.SetActive(false);
        director.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        player.transform.position = aniStartPos;
        EventStart();
    }

    private void EventStart()
    {
        //axeRender.enabled = false;
        Debug.Log("Play");
        director.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (director.state == PlayState.Paused)
            {
                director.Play();
            }
            else
            {
                director.Pause();
            }
        }
    }
}