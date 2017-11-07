using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTreeScript : MonoBehaviour
{
    public Animation AxeAni;

    private GameObject thornObject;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AxeAni.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreeObject") && AxeAni.isPlaying)
        {
            Debug.Log("나무 맞음");

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