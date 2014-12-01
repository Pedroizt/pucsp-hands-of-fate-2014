using UnityEngine;
using System.Collections;

public class LoadHistor : MonoBehaviour {

	// Use this for initialization

	public int historia;//numero para controlar qual cena sera carregada ao clicar em alguma opçao do modo historia.

	// Update is called once per frame

	//Caso certa parte da historia do inventario seja 
	void OnMouseDown()
	{

		//PlayerPrefs.SetInt( "previousLevel", Application.loadedLevel );
		//Carregamento de cena, adiciona a cena carregada, a mesma ja possui prioridade, o jogo esta pausado, pois esta no inventario.

		Application.LoadLevelAdditive(historia);
	}
}
