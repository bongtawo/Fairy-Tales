using System.Collections;
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

    public static void ReturnStroyScene(GameObject ob1, GameObject ob2)
    {
        ob1.SetActive(true);
        ob2.SetActive(true);
        SceneManager.UnloadSceneAsync("Action");
    }

    public static void SetObject(GameObject ob1, GameObject ob2)
    {
        playerObject = ob1;
        LightObject = ob2;
    }

    public static void ReturnStroyScene()
    {
        playerObject.SetActive(true);
        LightObject.SetActive(true);
        SceneManager.UnloadSceneAsync("Action");
    }
}