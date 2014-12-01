using UnityEngine;
using System.Collections;

public class SpawnRespawn : MonoBehaviour {

	//Utilizado para spawnar o inimigo APENAS UMA VEZ¹.
	public Object Inimigo; //Inimigo a ser adicionado.

	public bool EnemyDead = false; //Verificar se ele esta morto.
	public bool canRespawn = false; //Verificar se ele pode respawnar.
	GameObject ini; //OBjeto para clonagem do inimigo.





	// Use this for initialization
	void Start () {





			ini = Instantiate (Inimigo, transform.position, transform.rotation) as GameObject;
			//Cria um clone do inimigo, possibilitando a sua destruiçao*


				

	
	}





	
	// Update is called once per frame
	void Update () {

		if (EnemyDead == true) { //Caso o inimigo esteja morto, lançara uma coroutine.
			
			StartCoroutine(EnemyDefeated());
				
			}

		/*bool once = false;
		if (canRespawn == true)
		{
			if (once == false)
			{
				Invoke("Start", 3);
				EnemyDead = false;
				canRespawn = false;
				once = true;

			}
		}*/
						//StartCoroutine (Respawn ());
	
	}

	IEnumerator EnemyDefeated() //Espera dois segundos para que ele possa voltar ao estado original.
	{
		bool once = false;
		yield return new WaitForSeconds (2);
		{
			if (once == false)
			{
			ini.SetActive(false);
				once = true;
			}

		}
	}
	//¹ O script nao foi totalmente utilizado, apenas usado para instanciar os inimigos, bools de controle 
	//nao foram setadas.

	/*IEnumerator Respawn()
	{
		yield return new WaitForSeconds (3);
		{


			//Start ();
			if (EnemyDead == true)
				ini = Instantiate (Inimigo, transform.position, transform.rotation);

			EnemyDead = false;
			canRespawn = false;

						
				}
	}*/
}

/*No start, se o EnemyDead for falso, que é o padrão, 
ele instancia o inimigo. Quando a vida atual dele acaba, 
a classe dele fala que esse EnemyDead é true e aplica a bool 
CanRespawn. Se CanRespawn for true, ele vai chamar 
uma rotina depois de 3 segundos, onde se o EnemyDead 
for igual a true, outro inimigo vai ser criado e as 
bools vão resetar, assim o ciclo se repete*/
