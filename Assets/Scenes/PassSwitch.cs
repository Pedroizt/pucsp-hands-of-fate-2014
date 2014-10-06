using UnityEngine;
using System.Collections;

public class PassSwitch : MonoBehaviour {

	//criar uma bool, para ser ativada no stay e ser desativada no Exit.
	//criar outra classe, onde com a interaçao via teclado, da pra vc pegar o item se ele estiver de uma cor
	//Se ele n estiver da cor, n pode pega-lo.

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
