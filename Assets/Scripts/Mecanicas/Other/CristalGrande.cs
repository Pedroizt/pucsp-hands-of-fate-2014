using UnityEngine;
using System.Collections;

public class CristalGrande : MonoBehaviour {

	GameObject[] Count;
	public bool Cutscene = false;
	public GameObject cutscene;
	private float duration = 1.0f;
	float vel = 0.5f;




	// Use this for initialization
	public void Start () {



		cutscene.SetActive (false);
		Debug.Log ("estafuncionando");
		Count = GameObject.FindGameObjectsWithTag ("On");
		if (Count.Length == 4) {
			Destroy (gameObject,1);
			Cutscene = true;
			cutscene.SetActive(true);
			Debug.Log ("Funcionou");
		}





	
	}

	void Update()
	{

		transform.Rotate (0, vel, 0);
	}



	




}
