using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	//SCRIPT NAO UTILIZADO.
	//MOTIVO: O SCRIPT A SEGUIR E O DA SEGUNDA FASE, NAO IMPLEMENTADA.
	//O script a seguir e uma sala giratoria que seria controlada com switches (Outro teste).
	public bool girou = false;
	public bool naogirou = true;

	void Update()
	{

		if (Input.GetButtonDown("Trigger")) {
			if (naogirou == true && girou == false)
			{
			girou = true;
			naogirou = false;
			Debug.Log("girou a switch");
			}
		} 

		else if (Input.GetKeyDown(KeyCode.G))
		{

		 if (girou == true && naogirou == false){

				girou = false;
			naogirou = true;
			Debug.Log("nao girou a switch");
			}
		}
		
		
	}
}
