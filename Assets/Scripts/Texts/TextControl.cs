using UnityEngine;
using System.Collections;

public class TextControl : MonoBehaviour {

	public GameObject textbox;
	public TextMesh um;
	public TextMesh dois;
	public TextMesh tres;
	public TextMesh quatr;
	public TextMesh cin;
	public TextMesh sei;
	public TextMesh sete;
	public TextMesh oito;
	public TextMesh nov;
	public TextMesh dez;
	public TextMesh onze;

	// Use this for initialization
	void Start () {

		textbox.gameObject.renderer.enabled = false;
		um.gameObject.renderer.enabled = false;
		dois.gameObject.renderer.enabled = false;
		tres.gameObject.renderer.enabled = false;
		quatr.gameObject.renderer.enabled = false;
		cin.gameObject.renderer.enabled = false;
		sei.gameObject.renderer.enabled = false;
		sete.gameObject.renderer.enabled = false;
		oito.gameObject.renderer.enabled = false;
		nov.gameObject.renderer.enabled = false;
		dez.gameObject.renderer.enabled = false;
		onze.gameObject.renderer.enabled = false;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
