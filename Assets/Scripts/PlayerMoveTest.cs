using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMoveTest : MonoBehaviour
{
    private Camera cam;
    private float inputX, inputZ;
    private Vector3 setPosition;
    private float speed = 0.3f;

    private void Start()
    {
        //set start color
        SteamVR_Fade.Start(Color.white, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.clear, 2f);
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

        if (Input.GetButton("Cancel"))
        {
            Debug.Log("메뉴키");
        }
    }

    private void OnEnable()
    {
    }
}