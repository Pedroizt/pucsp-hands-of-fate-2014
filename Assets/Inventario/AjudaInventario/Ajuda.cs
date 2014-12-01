using UnityEngine;
using System.Collections;

public class Ajuda : MonoBehaviour {

	//Script usado para ativar a ajuda no inventario.

	//Variaveis publicas para armazenar GameObjects.
	public GameObject help;
	public GameObject crystal;


	//Caso o jogador tenha clicado no objeto, ele exibira a ajuda e removera o mesmo botao para que nao seja clicado novamente.
	void OnMouseDown()
	{
		help.SetActive (true);
		crystal.SetActive (false);

		}

	//Caso o jogador use o botao indicado, ele saira da ajuda, tirando o objeto homonimo e reativando o botao para clicar na ajuda.
	void Update(){
		if(Input.GetButtonDown("Trigger"))
		help.SetActive (false);
		crystal.SetActive (true);
	}
}
