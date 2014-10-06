using UnityEngine;
using System.Collections;

public class Ulck_mc : MonoBehaviour {

	private Encolhimento encolhimento;

	void Start () {
		GameObject character = GameObject.Find ("Sihir");
		encolhimento = character.GetComponent<Encolhimento> ();
		
	}

	void OnCollisionEnter(Collision col)
	{
		encolhimento.modificacorpo_locked = false;
		Destroy (gameObject);

	}
}
