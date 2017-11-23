using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHighLight : MonoBehaviour
{
    [HideInInspector] public bool highLighted;
    public TreePlayManager tpm;
    private int treeLife = 0;
    private int maxTreeLife = 10;

    private void OnEnable()
    {
        treeLife = maxTreeLife;
    }

    private void Start()
    {
        highLighted = false;
    }

    // Update is called once per frame
    private void Update()
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

    public bool HittedTree(int hitCount)
    {
        Debug.Log(hitCount);
        treeLife -= hitCount;
        if (treeLife <= 0)
        {
            gameObject.SetActive(false);
            tpm.SaveWood(1);
            return true;
        }
        else
        {
            return false;
        }
    }
}