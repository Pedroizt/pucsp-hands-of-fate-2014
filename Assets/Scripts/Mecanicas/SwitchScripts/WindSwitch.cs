using UnityEngine;
using System.Collections;

public class WindSwitch : MonoBehaviour {


	//Script para controlar as switches que sao ativadas apenas com o feitiço "Esferar".
	//private Hovering winds;
	public GameObject cameracutscene;//Controla a cutscene que mostra a ponte aparecendo.
	public bool switchon = false; //Mostra se a switch foi acionada ou nao.
	public GameObject target; //Objeto que ira aparecer caso a switch seja ativada (Ponte no caso).
	bool once = false;//Controle para evitar que a switch seja ativada novamente.


	void Start()
	{
		//A seguir, os objetos sao desativados.
		cameracutscene.SetActive (false);
		target.gameObject.SetActive (false);
	}

	void OnTriggerEnter (Collider col)
	{


			//Caso um objeto que possui a tag esferar passe pelo aro. O objeto aparecera, a switch estara acionada, e funcionara apenas uma vez
			if (col.gameObject.tag == "esferar" && once == false) {
						target.gameObject.SetActive (true);
						switchon = true;
						once = true;
						
				}
				
	}

	void Update()
	{ //Caso a bool esteja acionada, acontecera uma coroutine.

		if (switchon)
						StartCoroutine (cutscene ());

	}

	//Coroutine que controla o tempo em que a camera permanece mostrando a ponte. Apos o tempo estourar, ela volta a ficar inativa.
	IEnumerator cutscene()
	{
		cameracutscene.SetActive (true);
		yield return new WaitForSeconds(2);
		{
			cameracutscene.SetActive (false);
			switchon = false;
		}
	}
}
