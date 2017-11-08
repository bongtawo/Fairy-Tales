using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRControllerTracking : MonoBehaviour
{
    public XRNode trackingNode;

    private void Start()
    {
        if (XRSettings.enabled == false)
        {
            Debug.LogWarning("NO XR EXIST");
            this.enabled = false;
        }
    }

    private void Update()
    {
        transform.localPosition = InputTracking.GetLocalPosition(trackingNode);
        transform.localRotation =
        InputTracking.GetLocalRotation(trackingNode);
    }
}