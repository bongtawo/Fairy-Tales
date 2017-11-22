using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GoActionScene : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject mainLight;
    public PlayableDirector mainDirector;

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnEnable()
    {
        mainDirector.Pause();
        GameManager.LoadActionScene(mainPlayer, mainLight, mainDirector);
        //gameObject.GetComponent<Collider>().enabled = false;
    }
}