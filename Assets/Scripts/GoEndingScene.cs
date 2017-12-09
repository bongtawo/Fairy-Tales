using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoEndingScene : MonoBehaviour
{
    void OnDisable()
    {
        GameManager.PlayEnding();
    }
}