using UnityEngine;
using System.Collections;

public class Destroy2 : MonoBehaviour {

	GameObject[]Count;
	
	void OnMouseDown()
	{
		Count = GameObject.FindGameObjectsWithTag ("Roxo");
		if (Count.Length == 1) {
			Destroy (gameObject);
			Debug.Log ("Funcionou");
		} else {
			return;
		}
		
		
		
	}
}
