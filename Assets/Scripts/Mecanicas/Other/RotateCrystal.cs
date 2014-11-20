using UnityEngine;
using System.Collections;

public class RotateCrystal : MonoBehaviour {



	public bool girou;
	Xbox360_Controls XboxButton;

	void Awake () {
		
		GameObject x = GameObject.Find ("XboxControl");
		XboxButton = x.GetComponent <Xbox360_Controls> ();

	}

	void Update()
	{
		if (!girou)
			if (Input.GetKeyDown (KeyCode.F)||XboxButton.PressedButton == "B") 
			{
				girou = true;
				Debug.Log("girou a switch");
			}

		else if (girou) 
			if (Input.GetKeyDown(KeyCode.F)||XboxButton.PressedButton == "B")
			{
				girou = false;
				Debug.Log("nao girou a switch");
			}
						

	}
}
