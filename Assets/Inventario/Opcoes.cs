using UnityEngine;
using System.Collections;

public class Opcoes : MonoBehaviour {


	GameObject RealCamera;
	bool on = false;
	public GameObject activated;
	// Use this for initialization

	void Start()
	{
		 RealCamera = GameObject.Find("RealCamera");
	}

	void OnMouseDown()
	{
		on = !on;

		if (on == true)
		{
			Debug.Log("Desligado");
			activated.SetActive(false);
			RealCamera.GetComponent<SSAOEffect>().enabled = false;

		}

		if (on == false)
		{
			Debug.Log("ligado");
			activated.SetActive(true);
			RealCamera.GetComponent<SSAOEffect>().enabled = true;

		}
	}
}
