using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutTreeScript : MonoBehaviour
{
    public float axeMinSpeed = 10;
    public SteamVR_TrackedObject trackedObj;
    public Transform axeEndTransform;
    public ParticleSystem woodParticle;
    public Slider powerSlider;

    private GameObject thornObject;
    private SteamVR_Controller.Device device;
    private float axeSpeed;
    private Coroutine resetTree;
    private Coroutine longVib;
    public AudioSource axeSound;
    public AudioSource huaSound;
    private bool canHitTree = true;

    private Color chargeColor = Color.red;
    private Renderer swordRenderer;
    private Color currentEmissionColor = Color.black;
    private Renderer axeRenderer;

    private void Start()
    {
        axeRenderer = GetComponent<Renderer>();
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    private void FixedUpdate()
    {
        powerSlider.value -= Time.deltaTime;
        if (powerSlider.value < 0)
        {
            powerSlider.value = 0;
        }

        if (Input.GetAxis("Fire1") > 0.1f)
        {
            Charge();
        }

        currentEmissionColor = Color.Lerp(Color.black, chargeColor, powerSlider.value);
        axeRenderer.material.SetColor("_EmissionColor", currentEmissionColor);

        //Debug.Log("위치속도 : " + device.velocity.magnitude + ", 각속도 : " + device.angularVelocity.magnitude);

        axeSpeed = device.angularVelocity.magnitude;
        //Debug.Log(controllRigid.angularVelocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreeObject"))
        {
            Debug.Log("나무 맞음");

            if (axeSpeed > axeMinSpeed && canHitTree)
            {
                Debug.Log(axeSpeed);
                axeSound.Play();
                huaSound.Play();

                if (longVib != null)
                {
                    StopCoroutine(longVib);
                }

                var particle = Instantiate(woodParticle, axeEndTransform.position, axeEndTransform.rotation);
                particle.Play();

                /*thornObject = other.transform.GetChild(0).gameObject;
                if (thornObject.activeInHierarchy)
                {
                    thornObject.SetActive(false);
                }
                else*/
                CutTree(other);
                longVib = StartCoroutine(LongVibration(0.5f, 1f));
                StartCoroutine(WaitAxe());
            }
        }
    }

    /*private IEnumerator ResetTree(GameObject go, GameObject thorn)
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
    }*/

    private IEnumerator LongVibration(float length, float strength)
    {
        for (float i = 0; i < length; i += Time.deltaTime)
        {
            device.TriggerHapticPulse((ushort)Mathf.Lerp(0, 3999, strength));
            yield return null;
        }
    }

    private IEnumerator WaitAxe()
    {
        canHitTree = false;
        yield return new WaitForSeconds(0.5f);
        canHitTree = true;
    }

    private void CutTree(Collider tree)
    {
        if (powerSlider.value == 1)
        {
            tree.GetComponent<TreeHighLight>().HittedTree(10);
            powerSlider.value = 0;
        }
        else
        {
            tree.GetComponent<TreeHighLight>().HittedTree(1);
        }
    }

    private void Charge()
    {
        powerSlider.value += Time.deltaTime * 2;

        powerSlider.value = Mathf.Clamp01(powerSlider.value);
    }
}