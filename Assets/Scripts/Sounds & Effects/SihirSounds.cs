using UnityEngine;
using System.Collections;

public class SihirSounds : MonoBehaviour {


	public AudioSource SihirVoices;
	public AudioSource Heartbeat;
	public AudioSource Footsteps;
	public AudioSource History_au;
	public AudioSource Eras_au;
	public AudioSource Battle_au;
	public AudioSource EnemyAttack_au;
	public AudioSource SwitchSound_au;


	public AudioClip[] audioClip;
	public AudioClip Heart_Sihir;
	public AudioClip Footsteps_sihir;
	public AudioClip History_ac;
	public AudioClip Eras_ac;
	public AudioClip Battle_ac;
	public AudioClip EnemyAttack_ac;
	public AudioClip SwitchSound_ac;


	void Start ()
	{

		SihirVoices = (AudioSource)gameObject.AddComponent ("AudioSource");
		SihirVoices.volume = 0.5f;
		Heartbeat = (AudioSource)gameObject.AddComponent ("AudioSource");
		Heartbeat.volume = 0.5f;
		Footsteps = (AudioSource)gameObject.AddComponent ("AudioSource");
		Footsteps.volume = 0.5f;
		Eras_au = (AudioSource)gameObject.AddComponent ("AudioSource");
		Eras_au.volume = 0.65f;
		History_au = (AudioSource)gameObject.AddComponent ("AudioSource");
		History_au.volume = 0.65f;
		Battle_au = (AudioSource)gameObject.AddComponent ("AudioSource");
		Battle_au.volume = 0.65f;
		EnemyAttack_au = (AudioSource)gameObject.AddComponent ("AudioSource");
		EnemyAttack_au.volume = 0.5f;
		SwitchSound_au = (AudioSource)gameObject.AddComponent ("AudioSource");
		SwitchSound_au.volume = 0.5f;


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
	public void History_Music ()
	{
		
		History_au.clip = History_ac;
		History_au.Play ();
		
		
	}
	
	public void StopHistory ()
	{
		History_au.Stop ();
	}
	#endregion

	#region Eras Music Script
	public void ErasMusic ()
	{
		
		Eras_au.clip = Eras_ac;
		Eras_au.Play ();
		
		
	}
	
	public void ErasMute ()
	{
		Eras_au.mute = true;
	}

	public void ErasUnmute()
	{
		Eras_au.mute = false;

	}

	#endregion

	#region Battle Music Script
	public void BattleMusic ()
	{
		
		Battle_au.clip = Battle_ac;
		Battle_au.Play ();
		
		
	}
	
	public void BattleMute ()
	{
		Battle_au.mute = true ;
	}

	public void BattleUnmute ()
	{
		Battle_au.mute = false;
	}
	#endregion

	#region Enemy Attack Script
	public void EnemyAttack()
	{
		EnemyAttack_au.clip = EnemyAttack_ac;
		EnemyAttack_au.Play ();

	}
	#endregion

	#region Switch Script
	public void Switch_Sound ()
	{

		SwitchSound_au.clip = SwitchSound_ac;
		SwitchSound_au.Play ();

	}
	#endregion


}