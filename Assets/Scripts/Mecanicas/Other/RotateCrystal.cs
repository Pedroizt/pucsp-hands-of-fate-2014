using UnityEngine;
using System.Collections;

public class RotateCrystal : MonoBehaviour {


	/*SCRIPT NÃO UTILIZADO
	MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO 
	FUNÇAO: Auxilio na criaçao de sala giratoria.*/
	public bool girou;
	void Update()
	{
		if (!girou)
			if (Input.GetButtonDown("Trigger")) 
			{
				girou = true;
				Debug.Log("girou a switch");
			}

		else if (girou) 
			if (Input.GetButtonDown("Trigger"))
			{
				girou = false;
				Debug.Log("nao girou a switch");
			}
						

	}
}
