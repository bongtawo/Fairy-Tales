using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneChanger : MonoBehaviour
{
    public int gotoSceneNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (gotoSceneNum)
            {
                case 0:
                    SceneManager.LoadScene("Intro_scene");
                    break;

                case 1:
                    Debug.Log("개발중1");
                    break;

                case 2:
                    Debug.Log("개발중2");
                    break;

                case 3:
                    Debug.Log("개발중3");
                    break;

                default:
                    break;
            }
        }
    }
}