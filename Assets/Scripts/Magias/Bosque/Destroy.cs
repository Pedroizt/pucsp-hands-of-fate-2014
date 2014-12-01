using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE TERCEIRA FASE. NAO IMPLEMENTADO.
	 * FUNCAO: O Objeto a seguir so poderia ser destruido caso estivesse o objeto instanciado no jogo. */
	GameObject[]Count;

	void OnMouseDown()
	{
		Count = GameObject.FindGameObjectsWithTag ("Verde");
		if (Count.Length == 1) {
			Destroy (gameObject);
			Debug.Log ("Funcionou");
		} else {
			return;
		}



	}
}
