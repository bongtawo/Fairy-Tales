using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTreeScript : MonoBehaviour
{
    public float axeMinSpeed = 10;
    public SteamVR_TrackedObject trackedObj;
    public Transform axeEndTransform;
    public ParticleSystem woodParticle;

    private GameObject thornObject;
    private SteamVR_Controller.Device device;
    private float axeSpeed;
    private Coroutine resetTree;
    private Coroutine longVib;

    private void Start()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    private void FixedUpdate()
    {
        //Debug.Log("위치속도 : " + device.velocity.magnitude + ", 각속도 : " + device.angularVelocity.magnitude);

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