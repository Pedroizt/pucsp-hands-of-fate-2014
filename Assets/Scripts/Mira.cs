using UnityEngine;
using System.Collections;

public class Mira : MonoBehaviour {

	public Transform camera;

	void Update()
	{
		gameObject.transform.LookAt (camera);
		}
}
