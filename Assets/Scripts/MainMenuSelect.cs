using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSelect : MonoBehaviour
{
    private bool isTouched = false;
    private Vector3 scaleVector = new Vector3(1.5f, 1.5f, 1.5f);
    private Vector3 originVector = new Vector3(1, 1, 1);
    private AudioSource clickAudio;
    private AudioSource onAudio;

    public int storyNum;

    private void Start()
    {
        AudioSource[] audios = GetComponentsInParent<AudioSource>();
        onAudio = audios[0];
        clickAudio = audios[1];
    }

    private void Update()
    {
        if (isTouched)
        {
            if (Input.GetAxis("Fire2") > 0.1f)
            {
                clickAudio.Play();
                switch (storyNum)
                {
                    case 1:
                        UnityEngine.SceneManagement.SceneManager.LoadScene("Intro_Scene");
                        break;

                    default:
                        break;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
        transform.localScale = scaleVector;
        onAudio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        isTouched = false;
        transform.localScale = originVector;
    }

    IEnumerator StartStory()
    {
        yield return new WaitForSeconds(5);
    }
}