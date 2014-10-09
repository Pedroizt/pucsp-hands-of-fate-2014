using UnityEngine;
using System.Collections;

public class MenuFade : MonoBehaviour {

	public bool loadscreeen = false;
	bool StartScene = true;
	private ScriptNovoJogo newgame;
	private LoadScreen loader;

	// Use this for initialization
	void Start () {

		GameObject n = GameObject.Find ("NovoJogo");
		newgame = n.GetComponent<ScriptNovoJogo> ();

		GameObject l = GameObject.Find ("LoadScreen");
		loader = l.GetComponent<LoadScreen> ();




	}
	
	// Update is called once per frame
	void Update () {
	
		if (StartScene) {
						guiTexture.color = Color.Lerp (guiTexture.color, Color.clear, Time.deltaTime);
			if (guiTexture.color.a <= 0.05f)
				StartScene = false;
		}



		if (newgame.loading == true && loadscreeen == false) {
						guiTexture.color = Color.Lerp (guiTexture.color, Color.black, 5* Time.deltaTime);
						if (guiTexture.color.a >= 0.95f)
			{
			
							loadscreeen = true;
				Destroy(gameObject);
			}

						

		}

			
	}


}
