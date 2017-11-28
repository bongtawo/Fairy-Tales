using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour 
{
	private void Update() 
	{
		transform.LookAt(Camera.main.transform);
		// LootAt : 설정한 좌표로 계속 바라보게 하는 함수	
	}
}