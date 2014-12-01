using UnityEngine;
using System.Collections;

public class FragsOnInventory : MonoBehaviour {

	//Classe feita para adicionar os fragmentos de memoria que voce consegue no inventario.
	//public TextMesh text2;

	//variaveis para coletar componentes.
	private SeusFragmentos fragmentos;
	private Inventario invent;
	private TextMeshes texts;
	bool aparece;
	// Use this for initialization


	void Start(){

		//Objetos inicializados para coleta de componentes.
		GameObject f = GameObject.Find ("Frags");
		fragmentos = f.GetComponent<SeusFragmentos> ();

		GameObject i = GameObject.Find ("inventario 2");
		invent = i.GetComponent<Inventario> ();

		GameObject t = GameObject.Find ("TextMeshes");
		texts = t.GetComponent<TextMeshes> ();



		}
	// Update is called once per frame
	void Update () {

		//O numero e atualizado quando o personagem pega um novo fragmento, o convertendo para string
		//E exibindo no inventario.
		//Esses objetos nao irao aparecer caso o inventario nao esteja acionado.
		texts.text2.text = fragmentos.SihFrags.ToString() + "/25";
		texts.text3.text = fragmentos.AurFrags.ToString () + "/25";
		texts.text4.text = fragmentos.HistFrags.ToString () + "/25";
		texts.text5.text = fragmentos.MythFrags.ToString () + "/25";
		if (invent.isPause == false)
						gameObject.renderer.enabled = false;
						//gameObject.SetActive (false);
		else
						gameObject.renderer.enabled = true;

	
	}
}
