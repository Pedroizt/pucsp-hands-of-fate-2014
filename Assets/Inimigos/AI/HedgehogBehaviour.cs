using UnityEngine;
using System.Collections;

public class HedgehogBehaviour : MonoBehaviour {

	//O SCRIPT ABAIXO NAO FOI UTILIZADO.
	//MOTIVO: SUBSTITUIDO PELO HEDGEHOGHITBOX.

	public float HP;
	public float Damage;
	private Hpsih HPSihir;


	// Use this for initialization
	void Start () {

		GameObject h = GameObject.Find ("Sihir");
		HPSihir = h.GetComponent<Hpsih> ();



	
	}
	
	// Update is called once per frame
	void ApplyDamage()
	{
		HPSihir.curHealth -= Damage;
		Debug.Log ("Damaging");



	}
}
