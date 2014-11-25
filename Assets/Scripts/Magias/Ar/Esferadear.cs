using UnityEngine;
using System.Collections;

public class Esferadear : MonoBehaviour {

	public float damage = 2.0f;
	private SpellCast castspell;
	Transform target;
	GameObject esferar;
	private Hpsih hp;
	private TrueSihir tr;
	GameObject trsih;

	public SihirSounds SihirSounds;
	bool AtackSound;

	// Use this for initialization
	void Start () {

		GameObject s = GameObject.Find ("SpellCast");
		castspell = s.GetComponent<SpellCast> ();

		esferar = GameObject.Find ("boladear2");

		GameObject t = GameObject.Find ("Sihir");
		tr = t.GetComponent<TrueSihir> ();

		GameObject h = GameObject.Find ("Sihir");
		hp = h.GetComponent<Hpsih> ();

		trsih = GameObject.Find ("Sihir");

		GameObject a = GameObject.Find ("Sihir");
		SihirSounds = a.GetComponent <SihirSounds> ();

	
	}
	
	// Update is called once per frame
	void Update () {



		if (castspell.selo == "10") {

			GameObject s = GameObject.Find ("SpellCast");
			castspell = s.GetComponent<SpellCast> ();
			
			target = GameObject.Find ("Sihir/SpellCast").transform;

						GameObject obj = Instantiate (esferar, target.position, target.rotation) as GameObject;
						obj.rigidbody.AddForce (target.forward * 200 * Time.deltaTime);
						castspell.selo = "";
						Destroy (obj, 2);


			#region Atack Sound Switch
						if (AtackSound)
						{
							SihirSounds.PlaySound (0);
							AtackSound = false;
						}	
						else
						{
							SihirSounds.PlaySound (1);
							AtackSound = true;
						}
			#endregion


						hp.curHealth -= hp.maxHealth / 16;
			trsih.SendMessage("Attack", SendMessageOptions.DontRequireReceiver);


						//Confiugar velocidade da esfera para deixar igual a da particula
				} 
	
	}

	void OnTriggerEnter(Collider cols)
	{
		if (cols.gameObject.tag == "Enemy") {
			Debug.Log ("Colliding");
			cols.gameObject.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
		}
	}




}
