using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameObject playerObject;
    private static GameObject lightObject;
    private static PlayableDirector directorObject;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void LoadActionScene(GameObject ob1, GameObject ob2, PlayableDirector pd)
    {
        playerObject = ob1;
        lightObject = ob2;
        directorObject = pd;
        playerObject.SetActive(false);
        lightObject.SetActive(false);
        SceneManager.LoadScene("Action_02", LoadSceneMode.Additive);
    }

    public static void ReturnStroyScene()
    {
        playerObject.SetActive(true);
        lightObject.SetActive(true);
        SceneManager.UnloadSceneAsync("Action_02");
        directorObject.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}