using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Wizard_1 : MonoBehaviour
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
                answerTrue.GetComponentInChildren<Text>().text = "낡은 도끼";
                Debug.Log("낡은도끼");
                break;

            case 2:
                answerFalse.GetComponentInChildren<Text>().text = "금도끼, 은도끼";
                Debug.Log("금도끼,은도끼");
                break;

            default:
                break;
        }
        answerTrue.SetActive(false);
        answerFalse.SetActive(false);
    }

    // 씬 종료
    private bool sceneEnd = false;

    private void Start()
    {
        StartCoroutine(Showsub_5());
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "착한 나무꾼이군~!";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "흠, 분명 자네가 빠뜨린 것은 ";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "낡은 도끼 아닌가?";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "아무리  자네가 선한 일을 했어도";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "거짓말은 안되네!";
    }

    private IEnumerator Showsub_5()
    {
        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "반갑소 나무꾼";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자네가 빠뜨린 도끼가 어떤것인가?";

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}