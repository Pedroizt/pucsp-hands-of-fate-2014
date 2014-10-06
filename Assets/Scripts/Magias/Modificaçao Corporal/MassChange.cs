using UnityEngine;
using System.Collections;

public class MassChange : MonoBehaviour {

	private SpellCast spellcast1;
	private Encolhimento mc;
	private bool duracao;
	private GameObject longc;
	private GameObject _sih;

	// Use this for initialization
	void Start () {

		longc = GameObject.Find ("LongCast");
		spellcast1 = longc.GetComponent<SpellCast> ();

		_sih = GameObject.Find ("Sihir");
		mc = _sih.GetComponent<Encolhimento> ();


	
	}
	
	// Update is called once per frame
	void Update () {

		//MassChange
		
		if(spellcast1.selo == "0123" && mc.modificacorpo_locked == false && duracao == false)
			gameObject.rigidbody.mass = 10000;
	
	}
}
