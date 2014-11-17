using UnityEngine;
using System.Collections;

public class HedgehogBehaviour : MonoBehaviour {

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
	}
}
