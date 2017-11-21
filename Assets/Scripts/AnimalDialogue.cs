using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalDialogue : MonoBehaviour
{
    // 자막을 띄우는 UI 텍스트
    public Text nPCSubtitleText;

    private void Start()
    {
        StartCoroutine(ShowSub_1());
    }

    private IEnumerator ShowSub_1()
    {
        //자막뜨는 시간과 내용
        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무꾼님! 나무꾼님! 저 좀 도와주세요!";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = " 어제 저기 언덕에서 큰 돌이 굴러와 저희집을 망가뜨렸어요";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "집을 고쳐야 하는데 나무가 좀 필요해요";

        yield return new WaitForSeconds(3f);
        nPCSubtitleText.text = "나무 좀 구해다 주실 수 있으세요?";
    }
}