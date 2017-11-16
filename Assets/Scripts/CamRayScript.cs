using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRayScript : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, 5f))
        {
            if (hit.transform.CompareTag("TreeObject"))
            {
                hit.collider.gameObject.GetComponent<TreeHighLight>().highLighted = true;
            }
        }
    }
}