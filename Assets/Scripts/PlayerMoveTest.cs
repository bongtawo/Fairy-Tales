using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMoveTest : MonoBehaviour
{
    private Camera cam;
    private float inputX, inputZ;
    private Vector3 setPosition;
    private float speed = 0.1f;

    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");

        setPosition = cam.transform.forward * inputZ * speed;
        setPosition += cam.transform.right * inputX * speed;
        setPosition.y = 0;
        transform.position += setPosition;
    }
}