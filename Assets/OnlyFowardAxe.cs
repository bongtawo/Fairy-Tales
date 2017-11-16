using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyFowardAxe : MonoBehaviour
{
    public Collider forwardAxeCol;

    private void OnTriggerEnter(Collider other)
    {
        forwardAxeCol.enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        forwardAxeCol.enabled = true;
    }
}