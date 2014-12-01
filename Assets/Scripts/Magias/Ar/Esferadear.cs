using UnityEngine;
using System.Collections;

public class Esferadear : MonoBehaviour {

	//Esse script se trata do feitiço de Impactar.
	public float damage = 2.0f;//Dano do feitiço.
	//As variaveis a seguir, sao utilizadas para conseguir componentes de outros scripts
	private SpellCast castspell;
	private Hpsih hp;
	private TrueSihir tr;
	//As variaveis a seguir foram usadas para conseguir objetos.
	Transform target;
	GameObject esferar;
	GameObject trsih;
	//Sons
	public SihirSounds SihirSounds;
	bool AtackSound;

	// Use this for initialization
	void Start () {

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
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


		/*Caso a variavel da classe SpellCast chamada selo receba esses parametros, ele ira criar o objeto
		 *e adicionara uma força para que o mesmo va para frente. Ao ser instanciado, o mesmo solta um som. Ele 
		 *reseta a variavel da classe SpellCast, reduz 1/16 da vida maxima da personagem, e manda a mensagem 
		 *para a classe TrueSihir, executando o metodo "Attack" que aciona a animaçao dos dados, bursts e etc.
		 *Depois de dois segundos o gameobject desse script e destruido*/
		if (castspell.selo == "10" || castspell.selo == "R D ") {

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
