using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventChecker : MonoBehaviour
{
    public GameObject eventNpc;

    private PlayableDirector npcDirector1;

    // Use this for initialization
    void Start()
    {
        npcDirector1 = eventNpc.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("이벤트 발생");
        npcDirector1.Play();
        GetComponent<BoxCollider>().isTrigger = false;
        GetComponent<EventChecker>().enabled = false;
        if (other.CompareTag("EventObject"))
        {
        }
    }
}