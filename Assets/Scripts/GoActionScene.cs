using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoActionScene : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject mainLight;

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnEnable()
    {
        GameManager.LoadActionScene(mainPlayer, mainLight);
        gameObject.GetComponent<Collider>().enabled = false;
    }
}