using UnityEngine;
using System.Collections;

public class SihirSounds : MonoBehaviour {

	public AudioSource audiosource; 
	
	public AudioClip audioclip;
	
	
	void Start () {
		
		audiosource = (AudioSource)gameObject.AddComponent ("AudioSource");
		
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void SihirFootsteps () {
		
		//Sihir Footsteps
		/*audioclip = (AudioClip)Resources.Load ("SFX/Footsteps");
		audiosource.clip = audioclip;
		//audiosource.loop = true;
		audiosource.Play ();
		*/
	}

}
