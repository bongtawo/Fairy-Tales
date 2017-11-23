using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlayManager : MonoBehaviour
{
    private int maxNeedWood = 4;
    private int curWood = 0;

    public void SaveWood(int getWood)
    {
        curWood += getWood;

        Debug.Log("때린 나무 개수 : " + curWood);
        if (curWood >= maxNeedWood)
        {
            curWood = 0;
            GameManager.ReturnStroyScene();
        }
    }
}