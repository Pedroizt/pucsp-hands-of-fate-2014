using UnityEngine;
using System.Collections;

public class Mira : MonoBehaviour {

	//Script usado para que a mira esteja olhando sempre para a camera.
	public Transform camera;

	void Update()
	{
		gameObject.transform.LookAt (camera);
		}
}
