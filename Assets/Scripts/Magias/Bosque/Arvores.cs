using UnityEngine;
using System.Collections;

public class Arvores : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE TERCEIRA FASE. NAO IMPLEMENTADO.
	 * FUNCAO: Criar uma "arvore", que poderia ser usada como modificador para a magia de fogo.*/
	public Object GreenTree;
	public Object PurpleTree;
	public bool temarvore = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.F) && temarvore == false) {
			temarvore = true;
			Object obj = Instantiate(GreenTree, transform.position,transform.rotation);
			Destroy(obj, 3);
			StartCoroutine(boolvolta());
		}

		if (Input.GetKeyDown (KeyCode.G) && temarvore == false) {
			temarvore = true;
			Object obj = Instantiate(PurpleTree, transform.position,transform.rotation);
			Destroy(obj, 3);
			StartCoroutine(boolvolta());
		}


		  
	}

	IEnumerator boolvolta()
	{
		yield return new WaitForSeconds (3);
		temarvore = false;
	}
}
