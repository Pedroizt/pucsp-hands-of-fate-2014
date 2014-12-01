using UnityEngine;
using System.Collections;

public class CriadorLabirinto : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE QUARTA FASE. NAO IMPLEMENTADO.
	 * FUNÇAO: Auxilia na criaçao de um labirinto para o jogador ultrapassar.*/
	private int[,] labirinto;
	private int[,] labirinto2;
	// Use this for initialization
	void Start () 
	{
				labirinto = GeradorLabirinto.retornaLabirinto (0);
				for (int i=0; i<labirinto.GetLength(0); i ++)
						for (int z=0; z<labirinto.GetLength(1); z++) {
								if (labirinto [i, z] == 1) {
										Vector3 pos = new Vector3 (i, 0, z);
										GameObject p = Instantiate (Resources.Load ("tree")) as GameObject;


										p.transform.position = pos;
			
								}
						}

		}

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Escape)) {
						Application.Quit ();
				}
	}

}

