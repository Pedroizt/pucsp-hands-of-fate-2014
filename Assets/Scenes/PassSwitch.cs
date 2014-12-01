using UnityEngine;
using System.Collections;

public class PassSwitch : MonoBehaviour {

	//SCRIPT NAO UTILIZADO.
	//MOTIVO: O SCRIPT A SEGUIR E O DA SEGUNDA FASE, NAO IMPLEMENTADA.
	//O script a seguir controla a switch que funciona apenas quando o personagem esta na colisao.

	public bool ativado = false;

	void OnTriggerStay(Collider col)
	{
		Debug.Log ("Esta na Colisao");
		ativado = true;
	}

	void OnTriggerExit(Collider col)
	{
		Debug.Log ("Saiu da colisao");
		ativado = false;

	}

}
