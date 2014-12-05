using UnityEngine;
using System.Collections;

public class HedgehogHitbox : MonoBehaviour {


	//Abaixo estao variaveis utilizadas para armazenar componentes.
	private FollowEnemy fe;
	private Hpsih HPSihir;
	GameObject trs;
	SihirSounds Attack;
	float counter = 1;

	// Use this for initialization
	void Start () {

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject f = GameObject.Find ("bigcrush 1(Clone)/idle");
		fe = f.GetComponent<FollowEnemy> ();

		GameObject h = GameObject.Find ("Sihir");
		HPSihir = h.GetComponent<Hpsih> ();
		trs = GameObject.Find ("Sihir");
		Attack = h.GetComponent <SihirSounds> ();


	
	}

	/*O inimigo possui a propria "hitbox" em suas costas, ou seja, trigger. Caso a personagem entre em contato com ela
	A varivel que esta no personagem sera acionada, e sua vida diminuida com base no dano que e setado no script
	"FollowEnemy". Ele tambem manda uma mensagem para o script de personagem que aciona a bool avisando que ela tomou dano.
	a mesma ira avisar outro script disso.*/

	void Update()
	{
		 
		counter += Time.deltaTime;

	}

	void OnTriggerEnter(Collider col)
	{
		if (fe.attacktime == false) {
			Debug.Log ("Damaged");

			if (counter >= 1)
			{

				Attack.EnemyAttack ();
				counter = 0;

			}

			HPSihir.Damaged = true;
			HPSihir.curHealth -= fe.Damage;
			trs.SendMessage ("Damage", SendMessageOptions.DontRequireReceiver);

				}



	}

}
