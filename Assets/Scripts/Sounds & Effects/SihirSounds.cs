using UnityEngine;
using System.Collections;

public class SihirSounds : MonoBehaviour {


	public AudioSource SihirVoices;
	public AudioSource Heartbeat;
	public AudioSource Footsteps;
	public AudioSource Musics_au;

	public AudioClip[] audioClip;
	public AudioClip Heart_Sihir;
	public AudioClip Footsteps_sihir;
	public AudioClip[] Musics_ac;



	void Start ()
	{

		SihirVoices = (AudioSource)gameObject.AddComponent ("AudioSource");
		Heartbeat = (AudioSource)gameObject.AddComponent ("AudioSource");
		Footsteps = (AudioSource)gameObject.AddComponent ("AudioSource");
		Musics_au = (AudioSource)gameObject.AddComponent ("AudioSource");



	}


	#region Voices Script
	public void PlaySound (int clip)
	{

		SihirVoices.clip = audioClip[clip];
		SihirVoices.Play ();


	}

	public void StopSound ()
	{
		SihirVoices.Stop ();
	}
	#endregion

	#region Heart Script
	public void Heartbeating()
	{

		Heartbeat.clip = Heart_Sihir;
		Heartbeat.Play ();

	}

	public void StopHeart()
	{

		Heartbeat.Stop ();

	}
	#endregion

	#region Footsteps Script
	public void Footstep_Sound ()
	{
		
		Footsteps.clip = Footsteps_sihir;
		Footsteps.Play ();
		
		
	}

	public void MuteFootsteps()
	{

		Footsteps.mute = true;

	}

	public void UnMuteFootsteps()
	{

		Footsteps.mute = false;

	}

	
	public void StopFootsteps ()
	{
		Footsteps.Stop ();
	}
	#endregion

	#region History Music Script
	public void Musics (int clip)
	{
		
		Musics_au.clip = Musics_ac[clip];
		Musics_au.Play ();
		
		
	}
	
	public void StopMusic ()
	{
		Musics_au.Stop ();
	}
	#endregion

}