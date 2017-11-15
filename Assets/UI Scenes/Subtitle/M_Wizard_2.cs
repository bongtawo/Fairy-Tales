using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Wizard_2 : MonoBehaviour
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
        StartCoroutine(Showsub_4());
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "역시 그대는 선량하고 진실된 나무꾼이군";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "내가 그대에게모두 주겠네";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "분명 자네가 빠뜨린 것은 낡은 도끼 아닌가? ";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "그래도 그대가 한 착한 행동으로";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "내 이 금도끼,은도끼를 주겠네";
    }

    private IEnumerator Showsub_4()
    {
        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "반갑소";

        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "그대가 선량한 나무꾼인가? ";

        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "어떻게 알았냐고? 동물들이 일러주었네.";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자 어느것이 자네 도끼인가? ";

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}