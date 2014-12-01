using UnityEngine;
using System.Collections;

public class Encolhimento : MonoBehaviour {


	/*O script a seguir se trata de um dos feitiços do jogo*/


	public bool modificacorpo_locked = true; //Essa bool indica se o feitiço ja foi habilitado ou nao.
	private bool duracao = false;//Duraçao do feitiço, no caso, e o feitiço de encolhimento, o tempo indicado, e o tempo em que a personagem ficara pequena.
	//bool utlizada para que a personagem nao cresça incontroladamente, sendo ativado logo apos o feitiço.
	bool parardecrescer = false;

	//Variaveis usadas para conseguir variaveis de outros scripts.
	private GameObject longc;
	private Unlockeds un;



	private SpellCast spellcast1;
	// Use this for initialization
	void Start () {

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		 longc = GameObject.Find ("SpellCast");
		spellcast1 = longc.GetComponent<SpellCast> ();

		GameObject u = GameObject.Find ("UnObj");
		un = u.GetComponent<Unlockeds> ();

	
	}
	
	// Update is called once per frame
	void Update () {

				
		/*Usando o conceito de herança, esse script adquire a informaçao do script mestre, o "SpellCast" onde la armazena
		 * que numeros ou comandos foram usados. Caso os numeros 131 estejam na variavel selo e o feitiço esta habilitado 
		 * (No caso controlado pela bool de outro script) e o feitiço nao esta usando ja usado (controlado pela bool duracao)
		 * ele encolhe o personagem pela metade de seu tamanho e lança uma coroutine que traz a duraçao desse encolhimento, 
		 * e reseta a variavel do spellcast para que outros comandos sejam executados*/
				if (spellcast1.selo == "131" || spellcast1.selo == "R L R") {
							if(un.UnlockedBodyChange == true && duracao == false){
						transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
			duracao = true;
			StartCoroutine (duracaoencolhimento());
						spellcast1.selo = "";
			}




				}

		//Caso o personagem nao tenha aberto o feitiço, ele simplesmente reseta a variavel.
		if (spellcast1.selo == "131" && un.UnlockedBodyChange == false)
			spellcast1.selo = "";
		}

		
	//trata-se da duraçao de encolhimento, trazendo a bool no seu estado original, quando a mesma volta ao estado original,
	// o personagem volta ao tamanho normal, que e o dobro do seu tamanho atual.
		IEnumerator duracaoencolhimento()
	{
		yield return new WaitForSeconds (3);
			duracao = false;

		if (duracao == false)
						spellcast1.selo = "";
			transform.localScale = new Vector3 (transform.localScale.x * 2f, transform.localScale.y * 2f, transform.localScale.z * 2f);

	}
}
