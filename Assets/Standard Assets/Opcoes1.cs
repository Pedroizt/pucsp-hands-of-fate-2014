using UnityEngine;
using System.Collections;

public class Opcoes1 : MonoBehaviour {

	public string funcao1;
	public string funcao2;
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
			RealCamera.SendMessage(funcao1);
			activated.SetActive(false);
			

		}

		if (on == false)
		{
			Debug.Log("ligado");
			activated.SetActive(true);
			RealCamera.SendMessage(funcao2);

		}
	}
}
