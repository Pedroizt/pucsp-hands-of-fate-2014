using UnityEngine;
using System.Collections;

public class Wind2Switch : MonoBehaviour {

	//SCRIPT NAO UTILIZADO.
	//MOTIVO: CONSERTADO E SUBSTITUIDO PELO "WindSwitch.cs".
	private Hovering2 winds;
	
	void Start()
	{
		GameObject hovering = GameObject.Find ("Hover2Platform");
		winds = hovering.GetComponent<Hovering2> ();
	}
	
	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("Funcionou1");
		winds.switchon = true;
	}
}
