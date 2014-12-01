using UnityEngine;
using System.Collections;

public class Desoxigen : MonoBehaviour {

	//Esse script se trata do feitiço de desoxigenaçao.
	//public Object desoxig;
	//As variaveis a seguir, sao utilizadas para conseguir componentes de outros scripts
	private SpellCast castspell;
	private Hpsih hp;
	GameObject trsihir;
	Transform target;//utilizado para saber de onde sera instanciado.
	GameObject DesoxField;//objeto a ser instanciado.
	bool alive = false;//saber se ele continua existindo
	/*GameObject teste;
	int scalerate;*/
	public float damage = 0.5f; //Dano que o feitiço causa em inimigos.

	//as variaveis abaixo se tratam de controle de sons.
	bool AtackSound;

	public SihirSounds SihirSounds;//sons da personagem.






	void Start()
	{
		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject s = GameObject.Find ("SpellCast");
		castspell = s.GetComponent<SpellCast> ();
		DesoxField = GameObject.Find ("desoxfield");
		GameObject h = GameObject.Find ("Sihir");
		hp = h.GetComponent<Hpsih> ();
		trsihir = GameObject.Find ("Sihir");


		GameObject a = GameObject.Find ("Sihir");
		SihirSounds = a.GetComponent <SihirSounds> ();

	}
	void Update()
	{
	 
		float a;//teste
		bool ativo = false;//controle, o objeto esta inativo.


		/*Caso a variavel da classe SpellCast chamada selo receba esses parametros, ele ira criar o objeto
		 *e adicionara uma força para que o mesmo va para frente. Ao ser instanciado, o mesmo solta um som. Ele 
		 *reseta a variavel da classe SpellCast, reduz 1/8 da vida maxima da personagem, e manda a mensagem 
		 *para a classe TrueSihir, executando o metodo "Attack" que aciona a animaçao dos dados, bursts e etc.
		 *Depois de tres segundos o gameobject desse script e destruido*/
		if (castspell.selo == "01" || castspell.selo == "D R ") {

			GameObject s = GameObject.Find ("SpellCast");
			castspell = s.GetComponent<SpellCast> ();
			target = GameObject.Find ("Sihir/SpellCast").transform;

			GameObject obj = Instantiate (DesoxField, target.position, target.rotation) as GameObject;
			obj.rigidbody.AddForce(target.forward * 50);

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


			castspell.selo = "";
			hp.curHealth -= hp.maxHealth/8;
			trsihir.SendMessage("Attack", SendMessageOptions.DontRequireReceiver);
			Destroy(obj, 3);

		}


		
	}


	void OnTriggerEnter(Collider Col)
	{
		//Caso ele entre em contato com um objeto da tag fogo, ele ira destruir ele.
		if (Col.gameObject.tag == "Fire") {
			//Debug.Log("Esta Colidindo");
			Destroy(Col.gameObject);
				}
		//Caso ele entre em contato com um objeto da tag inimigo, ele manda a mensagem para aplicar o dano por toda familia do inimigo e usar o dano aqui declarado.
		if (Col.gameObject.tag == "Enemy") {
			Debug.Log ("Colliding");
			Col.gameObject.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
		}
	}









	// Use this for initialization
	/*void Start () {
		GameObject longcast = GameObject.Find ("LongCast");
		spellcast = longcast.GetComponent<SpellCast> ();



	
	}
	
	// Update is called once per frame
	void Update () {

						if (spellcast.selo == "01" && duracao == false) {


						Object obj = Instantiate (desoxig, transform.position, transform.rotation);
						duracao = true;
						StartCoroutine (ativo (obj));

						spellcast.selo = "";
						Destroy (obj, tempodeespera);

				} else if (spellcast.selo == "01" && duracao == true)
						spellcast.selo = "";
				}




						
				


	IEnumerator ativo(Object ob)
	{

						
		yield return new WaitForSeconds (tempodeespera);
		duracao = false;
				
				
	}*/



}
