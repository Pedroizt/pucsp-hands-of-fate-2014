using UnityEngine;
using System.Collections;

public class Destruicao : MonoBehaviour {

	//MAGIA DE IMPACTO
	//SELO: 83

	public float damage= 5.0f;
	private Hpsih hp;
	private SpellCast castspell;
	Transform impacto;
	Transform target;
	GameObject trsihir;

	public SihirSounds SihirSounds;
	bool AtackSound;


	//int range = 1;

	void Start()
	{
		GameObject s = GameObject.Find ("SpellCast");
		castspell = s.GetComponent<SpellCast> ();

		impacto = GameObject.Find ("impacto").transform;

		GameObject h = GameObject.Find ("Sihir");
		hp = h.GetComponent<Hpsih> ();

		trsihir = GameObject.Find ("Sihir");

		GameObject a = GameObject.Find ("Sihir");
		SihirSounds = a.GetComponent <SihirSounds> ();

		}
	

	/*void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Rocha" || destruirobject == true) {
			//Destroy (col.gameObject);
			Destroy (this.gameObject);
				}



	}*/

	void Update()
	{



		if (castspell.selo == "83") {
			target = GameObject.Find ("Sihir/SpellCast").transform;
			GameObject s = GameObject.Find ("SpellCast");
			castspell = s.GetComponent<SpellCast> ();

						Debug.Log ("Funciona");
			   			 Object obj = Instantiate(impacto, target.position, target.rotation);
						castspell.selo = "";

			
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

						hp.curHealth -= hp.maxHealth/16;
				Destroy((obj as Transform).gameObject, 1);
			trsihir.SendMessage("Attack", SendMessageOptions.DontRequireReceiver);

				}


	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Rocha") {

			Destroy(col.gameObject);
			//Destroy(gameObject);
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