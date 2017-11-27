using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneChanger : MonoBehaviour
{
    public int gotoSceneNum;
    public Text countText;

    private Coroutine coroutine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coroutine = StartCoroutine(BeforeEnterCount());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
            countText.text = "";
        }
    }

    private IEnumerator BeforeEnterCount()
    {
        countText.text = "3";
        yield return new WaitForSeconds(1);
        countText.text = "2";
        yield return new WaitForSeconds(1);
        countText.text = "1";
        yield return new WaitForSeconds(1);

        switch (gotoSceneNum)
        {
            case 0:
                SceneManager.LoadScene("Intro_Scene");
                break;

            case 1:
                countText.text = "개발중1";
                break;

            case 2:
                countText.text = "개발중2";
                break;

            case 3:
                countText.text = "개발중3";
                break;

            default:
                break;
        }
    }
}