using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (SceneManager.GetActiveScene().name)
            {
                case "Intro_Scene":
                    SceneManager.LoadScene("Animal_Deer_Scene");
                    break;

                case "Animal_Deer_Scene":
                    SceneManager.LoadScene("Animal_Tiger_Scene");
                    break;

                case "Animal_Tiger_Scene":
                    SceneManager.LoadScene("MountainGod_Scene");
                    break;

                case "Ending_Scene":
                case "Ending2_Scene":
                    SceneManager.LoadScene("MainMenu");
                    break;

                default:
                    break;
            }
        }
    }
}