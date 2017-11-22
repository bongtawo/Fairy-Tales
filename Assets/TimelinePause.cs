using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePause : MonoBehaviour {

public PlayableDirector pause;
	void Start () 
	{
		pause.Pause();
	}
}
