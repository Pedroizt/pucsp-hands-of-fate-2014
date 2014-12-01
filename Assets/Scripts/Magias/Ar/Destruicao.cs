using UnityEngine;
using System.Collections;

public class Destruicao : MonoBehaviour {

	//MAGIA DE IMPACTO
	//SELO: 83

	//Esse script se trata do feitiço de Impactar.
	public float damage= 5.0f; //Dano do feitiço;
	//As variaveis a seguir, sao utilizadas para conseguir componentes de outros scripts
	private Hpsih hp;
	private SpellCast castspell;

	//As variaveis a seguir foram usadas para conseguir objetos.
	Transform impacto;
	Transform target;
	GameObject trsihir;

	//Sons.
	public SihirSounds SihirSounds;
	bool AtackSound;


	//int range = 1;

	void Start()
	{
		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
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


		
		/*Caso a variavel da classe SpellCast chamada selo receba esses parametros, ele ira criar o objeto
		 *que e uma particula com colisao, o mesmo solta um som. Ele 
		 *reseta a variavel da classe SpellCast, reduz 1/16 da vida maxima da personagem, e manda a mensagem 
		 *para a classe TrueSihir, executando o metodo "Attack" que aciona a animaçao dos dados, bursts e etc.
		 *Depois de um segundo o gameobject desse script e destruido*/
		if (castspell.selo == "83" || castspell.selo == "U L ") {
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
		//Caso ele entre em contato com um objeto da tag rocha, ele ira destruir ele.
		if (col.gameObject.tag == "Rocha") {

			Destroy(col.gameObject);
			//Destroy(gameObject);
				}


	}

	void OnTriggerEnter(Collider cols)
	{
		//Caso ele entre em contato com um objeto da tag inimigo, ele manda a mensagem para aplicar o dano por toda familia do inimigo e usar o dano aqui declarado.
		if (cols.gameObject.tag == "Enemy") {
			Debug.Log ("Colliding");
			cols.gameObject.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
		}
	}
}