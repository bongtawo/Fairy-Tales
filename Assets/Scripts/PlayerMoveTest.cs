using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
    private float x, z;
    private float ry;

    private float speed = 0.1f;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        ry = Input.GetAxisRaw("Mouse X");

        transform.Translate(x * speed, 0, z * speed);
        transform.Rotate(0, ry, 0);
    }
}