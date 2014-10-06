using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	GameObject[]Count;

	void OnMouseDown()
	{
		Count = GameObject.FindGameObjectsWithTag ("Verde");
		if (Count.Length == 1) {
			Destroy (gameObject);
			Debug.Log ("Funcionou");
		} else {
			return;
		}



	}
}
