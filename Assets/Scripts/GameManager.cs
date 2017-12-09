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
    private static int axeSel = 0;

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
        SceneManager.LoadScene("MissionPlay_Scene", LoadSceneMode.Additive);
    }

    public static void ReturnStroyScene()
    {
        playerObject.SetActive(true);
        lightObject.SetActive(true);
        SceneManager.UnloadSceneAsync("MissionPlay_Scene");
        directorObject.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public static void ChangeAxeSel(int sel)
    {
        axeSel = sel;
    }

    public static void PlayEnding()
    {
        if (axeSel == 1)
        {
            SceneManager.LoadScene("Ending_Scene");
        }
        else if (axeSel == 2)
        {
            SceneManager.LoadScene("Ending2_Scene");
        }
    }
}