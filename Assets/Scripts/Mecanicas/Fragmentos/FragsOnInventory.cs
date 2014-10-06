using UnityEngine;
using System.Collections;

public class FragsOnInventory : MonoBehaviour {

	//public TextMesh text2;
	private SeusFragmentos fragmentos;
	private Inventario invent;
	private TextMeshes texts;
	bool aparece;
	// Use this for initialization


	void Start(){

		GameObject f = GameObject.Find ("Frags");
		fragmentos = f.GetComponent<SeusFragmentos> ();

		GameObject i = GameObject.Find ("Camera/inventario 2");
		invent = i.GetComponent<Inventario> ();

		GameObject t = GameObject.Find ("TextMeshes");
		texts = t.GetComponent<TextMeshes> ();



		}
	// Update is called once per frame
	void Update () {


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
