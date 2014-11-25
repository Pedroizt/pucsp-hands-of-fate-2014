using UnityEngine;
using System.Collections;

public class LoadHistor : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void OnMouseDown()
	{
		PlayerPrefs.SetInt( "previousLevel", Application.loadedLevel );
		Application.LoadLevelAdditive(4);
	}
}
