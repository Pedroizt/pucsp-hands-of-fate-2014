using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

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
