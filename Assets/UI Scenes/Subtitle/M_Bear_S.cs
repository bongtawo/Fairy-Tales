using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Bear_S : MonoBehaviour
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
                answerTrue.GetComponentInChildren<Text>().text = "그래";

                break;

            case 2:
                StartCoroutine(ShowSub_False());
                answerFalse.GetComponentInChildren<Text>().text = "미안하네";
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
        StartCoroutine(Showsub_3());
    }

    private IEnumerator ShowSub_True()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "자네같은 선한 나무꾼은";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "처음 보는군.고맙네";
    }

    private IEnumerator ShowSub_False()
    {
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "흥! 가는길에";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "몸 조심하는게 좋을게야!";
    }

    private IEnumerator Showsub_3()
    {
        ///*이봐, 나무꾼. 아주 좋은 도끼를 가지고 있군. 그걸로 나 좀 도와줄 수 있겠나? <그래 / 미안하네>*/
        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "이봐! 나무꾼";

        //yield return new WaitForSeconds(3f);
        //nPCSubtitleText.text = "아주 좋은 도끼를 가지고 있군";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "그걸로 나 좀 도와줄 수 있겠나?";

        yield return new WaitForSeconds(0.5f);
        answerTrue.SetActive(true);
        answerFalse.SetActive(true);
    }
}