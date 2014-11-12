using UnityEngine;
using System.Collections;

public class audioplay : MonoBehaviour {
	
	public AudioSource audiosource; 
	
	public AudioClip audioclip;
	
	
	void Start () {
		
		audiosource = (AudioSource)gameObject.AddComponent ("AudioSource");

	}

	public void MouseClick () {

		//Mouse sound on click
		audioclip = (AudioClip)Resources.Load ("SFX/MouseClick");
		audiosource.clip = audioclip;
		audiosource.Play ();

	}

	public void OnMouse () {

		//Mouse sound when passing
		audioclip = (AudioClip)Resources.Load ("SFX/MouseOver");
		audiosource.clip = audioclip;
		audiosource.Play ();

	}

	public void SihirFootsteps () {

		//Sihir Footsteps
		audioclip = (AudioClip)Resources.Load ("SFX/Footsteps");
		audiosource.clip = audioclip;
		//audiosource.loop = true;
		audiosource.Play ();

		}



}
