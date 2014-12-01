using UnityEngine;
using System.Collections;

public class Voltarpromenu : MonoBehaviour {


	//O script abaixo serve para voltar ao menu, o objeto desse script esta localizado apenas quando o inventario e acionado.
	public TextMesh Sair;

	// Use this for initialization



	void OnMouseEnter()
	{
		Sair.color = Color.red;
	}

	void OnMouseExit()
	{
		Sair.color = Color.black;
	}

	void OnMouseDown()
	{
		Application.LoadLevel (0);
	}
}
