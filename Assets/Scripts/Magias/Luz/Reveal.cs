using UnityEngine;
using System.Collections;

public class Reveal : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA/TERCEIRA FASE.
	 * FUNÇAO: Caso a esfera toque em um objeto as tags sugeridas, sua renderizaçao pode sumir
	 * ou aparecer, essencial para os puzzles da terceira fase.*/
	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "NoCollision")
						col.renderer.enabled = false;

		else if (col.gameObject.tag == "Invisivel")
			col.renderer.enabled = true;
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "NoCollision") {
						col.renderer.enabled = true;
				}

		else if (col.gameObject.tag == "Invisivel")
			col.renderer.enabled = false;

	}
}

