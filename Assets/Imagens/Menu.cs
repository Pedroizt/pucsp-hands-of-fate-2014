using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Color collor1;
	public GameObject Logo;
	public GameObject NewGame;
	public GameObject LoadGame;
	public GameObject Options;
	public GameObject Exit;
	public bool fadein = false;

	// Use this for initialization
	void Start () {

		collor1 = Logo.renderer.material.color;
		collor1.a = 0.0f;

		NewGame.collider.enabled = false;
		NewGame.renderer.enabled = false;
		LoadGame.SetActive (false);
		Options.SetActive (false);
		Exit.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (AparecerLogo ());

		if (fadein == true)
						collor1.a += 0.1f * Time.deltaTime;

		if (collor1.a >= 1.0f) {
			collor1.a = 1.0f;
						AparecerMenu ();
				}

		Logo.renderer.material.color = collor1;

		/*if (Input.GetKeyDown (KeyCode.F)) {
			collor1.a = 1.0f;
			fadein = true;

				}*/
	
	}

	IEnumerator AparecerLogo()
	{
		yield return new WaitForSeconds (5);
		fadein = true;

	}

	void AparecerMenu()
	{
		NewGame.collider.enabled = true;
		NewGame.renderer.enabled = true;
		LoadGame.SetActive (true);
		Options.SetActive (true);
		Exit.SetActive (true);
	}
}
