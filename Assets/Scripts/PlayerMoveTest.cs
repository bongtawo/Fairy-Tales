using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class PlayerMoveTest : MonoBehaviour
{
    private Camera cam;
    private float inputX, inputZ;
    private Vector3 setPosition;
    private float speed = 0.3f;
    public GameObject UIExit;

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

        if (Input.GetButtonDown("Cancel"))
        {
            if (UIExit.activeInHierarchy)
            {
                Application.Quit();
                Debug.Log("메뉴키");
                //Game 종료
            }
            else
            {
                StartCoroutine("ExitFalse");
                Debug.Log("한번더 누르면 종료됨");

                //한번더 누르면 게임이 종료됩니다
            }
        }
    }

    private IEnumerator ExitFalse()
    {
        UIExit.SetActive(true);
        yield return new WaitForSeconds(3f);
        UIExit.SetActive(false);
    }

    private void OnEnable()
    {
    }
}