using UnityEngine;
using System.Collections;

public class Placa : MonoBehaviour {


	/*SCRIPT NÃO UTILIZADO
	MOTIVO: SCRIPT DE TERCEIRA FASE. NAO IMPLEMENTADO.
	FUNÇAO: Criaria uma caixa de texto quando o personagem se aproximasse.*/
	bool toggleGui = false;

	void OnMouseDown()
	{
		toggleGui = true;
	}

	void OnMouseUp()
	{
		toggleGui = false;
		}

	void OnGUI()
	{
		if (Input.GetMouseButton(0)) {
			if (toggleGui == true)
			{
				Debug.Log ("Teste");
				GUI.Box (new Rect (0,Screen.height - 100, Screen.width, Screen.height -400), "TEXT");
			}
				}
	}
}
