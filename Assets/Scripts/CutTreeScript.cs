using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CutTreeScript : MonoBehaviour
{
<<<<<<< HEAD
    public float axeMinSpeed = 10;
    public SteamVR_TrackedObject trackedObj;
    public Transform axeEndTransform;
    public ParticleSystem woodParticle;

    private GameObject thornObject;
    private SteamVR_Controller.Device device;
    private float axeSpeed;
    private Coroutine resetTree;
    private Coroutine longVib;
=======
    public Animation AxeAni;
    public XRNode trackingNode;

    private GameObject thornObject;
>>>>>>> bb6b43b35f73b8f37c95b042863e50034f479f2a

    private void Start()
    {
        if (XRSettings.enabled == false)
        {
            Debug.LogWarning("NO XR EXIST");
            this.enabled = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
<<<<<<< HEAD
        //Debug.Log("위치속도 : " + device.velocity.magnitude + ", 각속도 : " + device.angularVelocity.magnitude);
=======
        if (Input.GetMouseButtonDown(0))
        {
            AxeAni.Play();
        }
>>>>>>> bb6b43b35f73b8f37c95b042863e50034f479f2a

        transform.localPosition = InputTracking.GetLocalPosition(trackingNode);
        transform.localRotation = InputTracking.GetLocalRotation(trackingNode);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("TreeObject") && AxeAni.isPlaying)
        if (other.gameObject.CompareTag("TreeObject"))
        {
            Debug.Log("나무 맞음");
<<<<<<< HEAD
            if (axeSpeed > axeMinSpeed)
            {
                Debug.Log(device.angularVelocity.magnitude);

                if (longVib != null)
                {
                    StopCoroutine(longVib);
                }

                var particle = Instantiate(woodParticle, axeEndTransform.position, axeEndTransform.rotation);
                particle.Play();

                thornObject = other.transform.GetChild(0).gameObject;
                if (thornObject.activeInHierarchy)
                {
                    thornObject.SetActive(false);
                }
                else
                {
                    other.gameObject.SetActive(false);
                    resetTree = StartCoroutine(ResetTree(other.gameObject, thornObject));
                }
                longVib = StartCoroutine(LongVibration(0.5f, 1f));
=======

            thornObject = other.transform.GetChild(0).gameObject;
            if (thornObject.activeInHierarchy)
            {
                thornObject.SetActive(false);
            }
            else
            {
                other.gameObject.SetActive(false);
                StartCoroutine(ResetTree(other.gameObject, thornObject));
>>>>>>> bb6b43b35f73b8f37c95b042863e50034f479f2a
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

    private IEnumerator LongVibration(float length, float strength)
    {
        for (float i = 0; i < length; i += Time.deltaTime)
        {
            device.TriggerHapticPulse((ushort)Mathf.Lerp(0, 3999, strength));
            yield return null;
        }
    }
}