using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRayScript : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, 50f))
        {
            if (hit.transform.CompareTag("TreeObject"))
            {
                hit.collider.gameObject.GetComponent<TreeHighLight>().highLighted = true;
            }
        }
    }
}