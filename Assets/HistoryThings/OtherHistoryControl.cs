using UnityEngine;
using System.Collections;

public class OtherHistoryControl : MonoBehaviour {

	//public Camera camera;
	public int parts;
	public GameObject[] Partes;
	public string level;
	public int i = 0;
	AsyncOperation async;
	public GameObject background;
	public TextMesh text1;
	public bool clear = false;
	public GameObject scene;
	public bool control;
	/*public bool começacutscene = false;
	bool fimdoarray = false;
	bool disable = false;
	
	public SihirSounds Music;
	
	public Color collor2;
	
	bool music_running = false;*/

	// Use this for initialization
	void Start () {


		Partes [i].renderer.enabled = true;
	
	
	}
	
	// Update is called once per frame
	void Update () {




		if (Input.GetButtonDown("Trigger") && i < parts) {

			i += 1;
			Partes [i].renderer.enabled = true;
			Partes [i - 1].renderer.enabled = false;
				
		}

		if (i >= parts)
		{
			if (control == false)
		{
				Destroy(scene);
			control = true;
			}
		}




	
	}

	
}
