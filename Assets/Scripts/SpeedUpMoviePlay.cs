using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;

public class SpeedUpMoviePlay : MonoBehaviour
{
    private PlayableDirector playerTimeLine;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetAxisRaw("Fire1") == 1)
        {
            Time.timeScale = 5f;
            GetComponent<VideoPlayer>().playbackSpeed = 5f;
        }
        else if (Input.GetAxisRaw("Fire1") == 0)
        {
            Time.timeScale = 1f;
            GetComponent<VideoPlayer>().playbackSpeed = 1f;
        }
    }
}