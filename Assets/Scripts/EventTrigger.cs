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
    public Transform aniStartPos;
    public PlayerMoveTest VRController;
    public AudioSource EventBgm;
    public AudioSource BirdFx;

    private void Start()
    {
        animal.SetActive(false);
        director.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        player.transform.position = aniStartPos.position;
        EventStart();
        gameObject.SetActive(false);
        VRController.enabled = false;
        EventBgm.Play();
        BirdFx.Stop();
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