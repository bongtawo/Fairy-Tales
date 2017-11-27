using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;

public class SpeedUpMoviePlay : MonoBehaviour
{
    PlayableDirector playerTimeLine;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Time.timeScale = 5f;
            GetComponent<VideoPlayer>().playbackSpeed = 5f;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            Time.timeScale = 1f;
            GetComponent<VideoPlayer>().playbackSpeed = 1f;
        }
    }
}