using UnityEngine;
using System.Collections;

public class SpawnRespawn : MonoBehaviour {

	public Object Inimigo;

	public bool EnemyDead = false;
	public bool canRespawn = false;
	Object ini;


	// Use this for initialization
	void Start () {



		if (EnemyDead == false) {

			ini = Instantiate (Inimigo, transform.position, transform.rotation);
		

				}

	
	}
	
	// Update is called once per frame
	void Update () {

		if (EnemyDead == true) {
			

				canRespawn = true;
				Destroy(ini);

			
		}

		bool once = false;
		if (canRespawn == true)
		{
			if (once == false)
			{
				Invoke("Start", 3);
				EnemyDead = false;
				canRespawn = false;
				once = true;

			}
		}
						//StartCoroutine (Respawn ());
	
	}

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
