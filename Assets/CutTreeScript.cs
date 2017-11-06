using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTreeScript : MonoBehaviour
{
    public Animation AxeAni;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AxeAni.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreeObject") && AxeAni.isPlaying)
        {
            Debug.Log("나무 맞음");
            Destroy(other.gameObject);
        }
    }
}