using UnityEngine;
using System.Collections;

public class RotateSwitch : MonoBehaviour {


	/*SCRIPT NÃO UTILIZADO
	MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO. 
	FUNÇAO: Cria uma switch rotacionavel.*/
	private RotateCrystal rotacionar;

	// Use this for initialization
	void Start () {

		GameObject r = GameObject.Find ("rotateswitch");
		rotacionar = r.GetComponent<RotateCrystal> ();
	
	}
	

	void Update ()
	{
		if (rotacionar.girou == false) {
						gameObject.transform.Rotate (0,-90, 0);
			rotacionar.girou = true;
				}

	}
	
	// Update is called once per frame

	
}
