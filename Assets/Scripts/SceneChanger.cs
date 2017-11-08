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
                case "S0_scene":
                    SceneManager.LoadScene("S1_scene");
                    break;

                case "S1_scene":
                    SceneManager.LoadScene("S2_scene");
                    break;

                case "S2_scene":
                    SceneManager.LoadScene("S3_scene");
                    break;

                case "S3_scene":
                    SceneManager.LoadScene("S4_scene");
                    break;

                case "S4_scene":
                    SceneManager.LoadScene("S5_scene");
                    break;

                default:
                    break;
            }
        }
    }
}