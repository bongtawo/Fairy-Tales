using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Wizard_0 : MonoBehaviour
{
    // 자막을 띄우는 UI 텍스트
    public Text nPCSubtitleText;

    public GameObject answerTrue;
    public GameObject answerFalse;

    //선택문
    public void Choice(int input)
    {
        switch (input)
        {
            case 1:
                StartCoroutine(ShowSub_True());
                Debug.Log("낡은도끼");
                break;

            case 2:
                StartCoroutine(ShowSub_False());
                Debug.Log("금도끼,은도끼");
                break;

            default:
                break;
        }
        answerTrue.SetActive(false);
        answerFalse.SetActive(false);
        Debug.Log("꺼져랏");
    }

    // 씬 종료
    private bool sceneEnd = false;

    private void Start()
    {
        StartCoroutine(Showsub_6());
        answerTrue.SetActive(false);
        answerFalse.SetActive(false);
        answerTrue.GetComponentInChildren<Text>().text = "낡은 도끼";
        answerFalse.GetComponentInChildren<Text>().text = "금도끼, 은도끼";
        Debug.Log("skdhkfkt");
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "그래, 네 도끼를 가지고 가라";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "거짓말 하는 아주 못된 나무꾼이군!";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자네에게는 아무것도 줄수가 없네!";
    }

    private IEnumerator Showsub_6()
    {
        //yield return new WaitForSeconds(3f);

        //nPCSubtitleText.text = "흠...";

        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "누가 나의 잠을 깨우는가?";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자네가 빠뜨린 도끼나 빨리찾아가게나";

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}