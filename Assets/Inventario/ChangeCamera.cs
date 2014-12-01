using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {


	//O script abaixo e utilizado para controlar as abas do inventario.

	public GameObject camerainvent; //Objeto que armazena a camera do inventario

	void OnMouseDown()
	{
		if (gameObject.tag == "Direita")
			camerainvent.transform.Rotate (0, 90, 0); //Caso o objeto que tenha essa tag seja clicado, a camera rotacionara 90 graus.

		if (gameObject.tag == "Esquerda")
			camerainvent.transform.Rotate (0, -90, 0);//Caso o objeto que tenha essa tag seja clicado, a camera rotacionara -90 graus.
	}

	//Caso o mouse esteja em cima do objeto, a cor dele mudara.
	void OnMouseOver()
	{
		gameObject.renderer.material.color = Color.yellow;
	}

	//Caso nao esteja mais, voltara ao normal.
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
