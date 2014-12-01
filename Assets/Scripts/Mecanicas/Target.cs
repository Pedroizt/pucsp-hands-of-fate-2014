using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	//SCRIPT NAO UTILIZADO.
	//MOTIVO: O INVENTARIO NAO PRECISOU DE UMA CONVERSAO DO PONTEIRO DO MOUSE.
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
				Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector3 toMousePosition = mousePositionInWorld - transform.position;
				transform.up = toMousePosition;
		}
}
