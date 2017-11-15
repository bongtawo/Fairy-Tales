using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Wolf_S : MonoBehaviour
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
                answerTrue.GetComponentInChildren<Text>().text = "좋아";
                Debug.Log("true");
                break;

            case 2:
                StartCoroutine(ShowSub_False());
                answerFalse.GetComponentInChildren<Text>().text = "다른데 알아보슈";
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
        StartCoroutine(Showsub_2());
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자네는 정말 좋은 나무꾼이네!";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "내 반드시 자네를 기억하겠네";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "에휴.. 좀 도와주면 안되겠나?";
    }

    private IEnumerator Showsub_2()
    {
        ///*어이 나무꾼! 어딜 그리 급히 가니?
        //지금 숲속 계곡에 다리를 놓고 있는데 말이야, 
        //나무가 좀 부족해혹시 나무 좀 구해 줄 수 있니? 
        //<좋아 / 다른데 알아보슈>*/
        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "어이 나무꾼! 어딜 그리 급히 가니?";

        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "지금 숲속 계곡에 다리를 놓고 있는데 말이야";

        yield return new WaitForSeconds(0.5f);
        nPCSubtitleText.text = "나무가 좀 부족해혹시 나무 좀 구해 줄 수 있니? ";

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}