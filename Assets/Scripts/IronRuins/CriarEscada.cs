using UnityEngine;
using System.Collections;

public class CriarEscada : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	 * FUNÇAO: Auxilio na criaçao de escadas.*/
	public bool semescadas = true;

	void OnMouseDown(){
		semescadas = false;
	}
}
