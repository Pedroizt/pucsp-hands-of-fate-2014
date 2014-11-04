using UnityEngine;
using System.Collections;

public class Esferadear : MonoBehaviour {

	public float damage = 2.0f;
	private SpellCast castspell;
	Transform target;
	GameObject esferar;
	private Hpsih hp;

	// Use this for initialization
	void Start () {

		GameObject s = GameObject.Find ("SpellCast");
		castspell = s.GetComponent<SpellCast> ();

		target = GameObject.Find ("Senpai Notice Me/SpellCast").transform;
		esferar = GameObject.Find ("boladear2");

		GameObject h = GameObject.Find ("Senpai Notice Me");
		hp = h.GetComponent<Hpsih> ();

	
	}
	
	// Update is called once per frame
	void Update () {



		if (castspell.selo == "10") {
						GameObject obj = Instantiate (esferar, target.position, target.rotation) as GameObject;
						obj.rigidbody.AddForce (target.forward * 200 * Time.deltaTime);
						castspell.selo = "";
						Destroy (obj, 2);
						hp.curHealth -= hp.maxHealth / 16;


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
