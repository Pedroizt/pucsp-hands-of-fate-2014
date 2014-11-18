using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public void Paused()
	{
		Time.timeScale = 0;
	}

	public void UnPause()
	{
		Time.timeScale = 1;
	}

}
