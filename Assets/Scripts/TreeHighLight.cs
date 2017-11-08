using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHighLight : MonoBehaviour
{
    [HideInInspector] public bool highLighted;

    private void Start()
    {
        highLighted = false;
    }

    // Update is called once per frame
    void Update()
    {
        var shader1 = Shader.Find("Self-Illumin/Diffuse");
        var shader2 = Shader.Find("Diffuse");

        if (highLighted == true)
            GetComponent<Renderer>().material.shader = shader1;
        else
            GetComponent<Renderer>().material.shader = shader2;
    }

    private void LateUpdate()
    {
        highLighted = false;
    }
}