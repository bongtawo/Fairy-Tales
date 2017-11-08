using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void ReturnStroyScene()
    {
        //GameObject.Find("VR Player").SetActive(true);
        //GameObject.FindGameObjectWithTag("MainLight").SetActive(true);
        SceneManager.UnloadSceneAsync("Action");
    }
}