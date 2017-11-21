﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameObject playerObject;
    private static GameObject LightObject;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void LoadActionScene(GameObject ob1, GameObject ob2)
    {
        playerObject = ob1;
        LightObject = ob2;
        playerObject.SetActive(false);
        LightObject.SetActive(false);
        SceneManager.LoadScene("Action_02", LoadSceneMode.Additive);
    }

    public static void ReturnStroyScene()
    {
        playerObject.SetActive(true);
        LightObject.SetActive(true);
        SceneManager.UnloadSceneAsync("Action_02");
    }
}