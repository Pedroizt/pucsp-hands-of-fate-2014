using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public GameObject camerainvent;

	void OnMouseDown()
	{
		if (gameObject.tag == "Direita")
			camerainvent.transform.Rotate (0, 90, 0);

		if (gameObject.tag == "Esquerda")
			camerainvent.transform.Rotate (0, -90, 0);
	}

	void OnMouseOver()
	{
		gameObject.renderer.material.color = Color.yellow;
	}

	void OnMouseExit()
	{
		gameObject.renderer.material.color = Color.white;
		}
	/*void Update ()
	{
		if (Input.GetMouseButtonDown(0)) {

			if (gameObject.tag == "Direita")
						camerainvent.transform.Rotate (0, 90, 0);
				}

		if (Input.GetMouseButtonDown(0)) {
						
			if (gameObject.tag == "Esquerda")
						camerainvent.transform.Rotate (0, -90, 0);
				}
						

	}*/
}
