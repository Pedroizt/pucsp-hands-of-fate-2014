using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public bool girou = false;
	public bool naogirou = true;
	Xbox360_Controls XboxButton;

	void Awake ()
	{

		GameObject x = GameObject.Find ("XboxControl");
		XboxButton = x.GetComponent <Xbox360_Controls> ();

	}

	void Update()
	{

		if (Input.GetKeyDown (KeyCode.F) || XboxButton.PressedButton == "Y") {
			if (naogirou == true && girou == false)
			{
			girou = true;
			naogirou = false;
			Debug.Log("girou a switch");
			XboxButton.NullButton ();
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
