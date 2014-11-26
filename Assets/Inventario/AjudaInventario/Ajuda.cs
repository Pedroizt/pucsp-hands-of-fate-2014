using UnityEngine;
using System.Collections;

public class Ajuda : MonoBehaviour {

	public GameObject help;
	public GameObject crystal;


	void OnMouseDown()
	{
		help.SetActive (true);
		crystal.SetActive (true);

		}

	void Update(){
		if(Input.GetButtonDown("Trigger"))
		help.SetActive (false);
		crystal.SetActive (true);
	}
}
