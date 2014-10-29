using UnityEngine;
using System.Collections;

public class Voltarpromenu : MonoBehaviour {

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
