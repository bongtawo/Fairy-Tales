using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerAnimal : MonoBehaviour
{
    private void OnEnable()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Dialogue_Test":
                Debug.Log("Change Scene to Action_02");
                SceneManager.LoadScene("MissionPlay_Scene", LoadSceneMode.Additive);
                break;

            case "MainMenu":
                SceneManager.LoadScene("Intro_scene");
                break;

            default:
                break;
        }
    }
}