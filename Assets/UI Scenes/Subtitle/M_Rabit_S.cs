using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Rabit_S : MonoBehaviour
{
    // 자막을 띄우는 UI 텍스트
    public Text nPCSubtitleText;

    public GameObject answerTrue;
    public GameObject answerFalse;

    private void Start()
    {
        StartCoroutine(ShowSub_1());
    }

    //선택문
    public void Choice(int input)
    {
        switch (input)
        {
            case 1:
                StartCoroutine(ShowSub_True());
                answerTrue.GetComponentInChildren<Text>().text = "그래 알았어~";
                Debug.Log("true");
                break;

            case 2:
                StartCoroutine(ShowSub_False());
                answerFalse.GetComponentInChildren<Text>().text = "지금바빠";
                break;

            default:
                break;
        }
        answerTrue.SetActive(false);
        answerFalse.SetActive(false);
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무꾼님! 너무 감사해요!";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "이 은혜는잊지 않을게요!";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "실망이에요! 흥!";
    }

    private IEnumerator ShowSub_1()
    {
        /*
        나무꾼님! 나무꾼님!
        저 좀 도와주세요! 어제 저기 언덕에서 
        큰 돌이 굴러와 저희집을 망가뜨렸어요. 
        집을 고쳐야 하는데 나무가 좀 필요해요. 
        나무 좀 구해다 주실 수 있으세요?
        <그래 알았어 / 지금 바빠!>
        */

        /*
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무꾼님! 나무꾼님! 저 좀 도와주세요!";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = " 어제 저기 언덕에서 큰 돌이 굴러와 저희집을 망가뜨렸어요";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "집을 고쳐야 하는데 나무가 좀 필요해요";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무 좀 구해다 주실 수 있으세요?";

        yield return new WaitForSeconds(3f);
        */

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}