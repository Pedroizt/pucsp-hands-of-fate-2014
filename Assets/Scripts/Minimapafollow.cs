using UnityEngine;
using System.Collections;

public class Minimapafollow : MonoBehaviour {

	//O script a seguir e utilizado para criar o minimapa.
	public GameObject Target;
	float zi;

	// Use this for initialization
	void Start () {

		gameObject.camera.pixelRect = new Rect(Screen.width - 170, Screen.height - 170, 140, 140);
	
	}
	
	// Update is called once per frame
	void Update () {

		//A camera do minimapa e atualizada com a posiçao de um objeto que esta sobre a personagem e que e movimentado 
		// junto a ela, o mesmo nao e renderizado com a cemera comum.
		gameObject.transform.position = Target.transform.position;
	
	}
}
