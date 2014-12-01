using UnityEngine;
using System.Collections;

public class ChangePlace : MonoBehaviour {

	//SCRIPT NAO UTILIZADO
	//MOTIVO: SCRIPT DA SEGUNDA FASE DO JOGO. NAO IMPLEMENTADO. 
	//FUNÇAO: TROCAR OBJETOS DE LUGAR APOS UM TEMPO.

	public Transform posicao1;
	public Transform posicao2;
	bool repetirrotina = true;
	float Timer;
	float seconds = 5;



	void Start()
	{

		Timer = 0f;


	}
	/*void OnMouseDown()
	{
		transform.position = posicao1.position;
	}

	void OnMouseUp()
	{
		transform.position = posicao2.position;
	}*/

	void FixedUpdate()
	{
		Timer += Time.deltaTime;

		if (Timer <= 5f)
						transform.position = posicao1.position;

		else  {
		transform.position = posicao2.position;
		

			StartCoroutine(resetar());
				}




	}

	IEnumerator resetar ()
	{
		yield return new WaitForSeconds (seconds);
		Timer = 1f;

	}
	


}
