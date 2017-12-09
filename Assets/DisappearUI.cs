using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisappearUI : MonoBehaviour
{
    public Image img;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ImageSetAppear());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator ImageSetAppear()
    {
        yield return new WaitForSeconds(3);
        img.CrossFadeColor(new Color(0, 0, 0, 0), 2f, false, true);
    }
}