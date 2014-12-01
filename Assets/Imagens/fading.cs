using UnityEngine;
using System.Collections;

public class fading : MonoBehaviour {


	//O script abaixo trata-se de outro fade, tem a mesma funçao que o MenuFade.cs

	public bool fadeout = false;
	public Color collor;

	// Use this for initialization
	void Start () {

		collor = gameObject.renderer.material.color;
		collor.a = 0.0f;




	
	}
	
	// Update is called once per frame
	void Update () {



		if (fadeout == false) {
						collor.a += 0.1f * Time.deltaTime * 2;
						if (collor.a >= 1.0f)
						fadeout = true;
				}

		if (fadeout == true)
						StartCoroutine (fade ());
						
		if (fadeout == true && collor.a <= 0.01f)
						Application.LoadLevel (1);

		gameObject.renderer.material.color = collor;



	
	}

	IEnumerator fade()
	{
		yield return new WaitForSeconds (2);
		collor.a -= 0.1f * Time.deltaTime * 2;
	}


}
