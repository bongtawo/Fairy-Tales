using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTreeScript : MonoBehaviour
{
    public float axeMinSpeed = 10;
    public SteamVR_TrackedObject trackedObj;

    private GameObject thornObject;
    private SteamVR_Controller.Device device;
    private float axeSpeed;

    private void Start()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    private void FixedUpdate()
    {
        Debug.Log("위치속도 : " + device.velocity.magnitude + ", 각속도 : " + device.angularVelocity.magnitude);

        axeSpeed = device.angularVelocity.magnitude;
        //Debug.Log(controllRigid.angularVelocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreeObject"))
        {
            Debug.Log("나무 맞음");
            if (axeSpeed > axeMinSpeed)
            {
                //if (axeRigid.velocity.magnitude > axeSpeed)

                Debug.Log(device.velocity);
                thornObject = other.transform.GetChild(0).gameObject;
                if (thornObject.activeInHierarchy)
                {
                    thornObject.SetActive(false);
                }
                else
                {
                    other.gameObject.SetActive(false);
                    StartCoroutine(ResetTree(other.gameObject, thornObject));
                }
            }
        }
    }

    private IEnumerator ResetTree(GameObject go, GameObject thorn)
    {
        yield return new WaitForSeconds(3);
        if (Random.Range(0, 2) == 1)
        {
            thorn.SetActive(true);
        }
        else
        {
            thorn.SetActive(false);
        }
        go.SetActive(true);
    }
}