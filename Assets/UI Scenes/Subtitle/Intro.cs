using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // 자막을 띄우는 UI 텍스트
    public Text nPCSubtitleText;

    public GameObject nextButton;

    private void Start()
    {
        StartCoroutine(ShowSub_1());
    }

    private IEnumerator ShowSub_1()
    {
        /*
        //옛날 효성이 지극한 나무꾼이 숲속마을에 살고 있었습니다. 
        //나무꾼은 매일아침이면 일찍일어나 숲속으로나무를 하러갔습니다.
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "옛날 효성이 지극한 나무꾼이 숲속마을에 살고 있었습니다";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무꾼은 매일아침이면 일찍일어나 숲속으로나무를 하러갔습니다";

        //어느 날, 숲속 나무에 이상한 변화가 생긴 것을 감지하게 됩니다. 
        //나무를 해서 장작을 떼려고 하면 불이 잘 붙지 않는 것입니다. 
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "어느 날, 숲속 나무에 이상한 변화가 생긴 것을 감지하게 됩니다";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무를 해서 장작을 떼려고 하면 불이 잘 붙지 않는 것입니다";

        //그 이유가 궁금한 나무꾼은 숲속 산신령을 
        //만나서 물어보기 위해 숲속깊이 들어 갑니다.
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "그 이유가 궁금한 나무꾼은";
         */

        yield return new WaitForSeconds(3f);
        nextButton.GetComponentInChildren<Text>().text = "산신령을 만나서 물어보기 위해 숲속깊이 들어 갑니다.";
        nextButton.SetActive(true);
    }

    public void LoadScene(int sceneNumber)
    {
        switch (sceneNumber)
        {
            case 1:
                SceneManager.LoadScene("Rabit");
                Debug.Log("Scene");
                break;

            case 2:
                SceneManager.LoadScene("Wolf");
                Debug.Log("낡은도끼");
                break;

            case 3:
                SceneManager.LoadScene("Bear");
                Debug.Log("낡은도끼");
                break;

            default:
                break;
        }
    }
}