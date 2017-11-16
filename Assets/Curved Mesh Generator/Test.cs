using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	public void OnClick()
	{
		Debug.Log("Clicked Curved Object !! - " + gameObject.name);
	}

	public void OnHover()
	{
		GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.7f, 1f), Random.Range(0.7f, 1f), Random.Range(0.7f, 1f));
	}
}