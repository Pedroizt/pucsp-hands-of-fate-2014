using UnityEngine;
using System.Collections;

public class CameraCutscene : MonoBehaviour {


	//Esse script tem como objetivo executar a cutscene onde o cristal grande da fase desaparece.
	//Variavel que ira coletar o componente de outro script.
	private CristalGrande cgrande;
	// Use this for initialization
	void Start () {

		//A inicializaçao abaixo armazena o componente de outro script.
		//O objeto ja esta inativo.
		GameObject c = GameObject.Find ("CristalGrande");
		cgrande = c.GetComponent<CristalGrande> ();

	
	}
	
	// Update is called once per frame
	void Update () {


		//Caso a variavel do script seja acionada, uma coroutine e ativada.
		if (cgrande.Cutscene == true) {
						
			//Debug.Log("SendMessage");

			            StartCoroutine(voltabool());
				}


	
	}

	IEnumerator voltabool()
	{
		//Apos um tempo, este gameobject volta a ficar inativo.
		yield return new WaitForSeconds(3);
		{
			   			//Debug.Log ("FuncionaChan");
					
						gameObject.SetActive(false);
						
				}
		}
}
