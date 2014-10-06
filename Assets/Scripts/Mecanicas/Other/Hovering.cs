using UnityEngine;
using System.Collections;

public class Hovering : MonoBehaviour {

	public float hoverforce = 10;
	float variacao = 1;
	public bool switchon = false;
	public bool Hover = false;
	Transform target;
	private WindSwitch winds;


	void Start()
	{




	}

	void Update()
	{
		if (winds.switchon)
						Debug.Log ("Funfa");
						//gameObject.SetActive (true);
	}


}
