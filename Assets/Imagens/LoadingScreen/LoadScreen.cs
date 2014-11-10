using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {


	//public string LeveltoLoad;
	AsyncOperation async;
	bool test2;
	public TextMesh presstart;
	public GameObject background;
	public TextMesh text1;
	public bool clear = false;
	public GameObject progressbar;
	bool test = false;
	private ScriptNovoJogo novojogo;
	private MenuFade Fade;
	private int LoadProgress = 0;



	// Use this for initialization
	void Start () {

		bool test = false;

		GameObject n = GameObject.Find ("NovoJogo");
		novojogo = n.GetComponent<ScriptNovoJogo> ();

		GameObject f = GameObject.Find ("screenfader");
		Fade = f.GetComponent<MenuFade> ();

		presstart.renderer.enabled = false;
		background.SetActive (false);
		text1.renderer.enabled = false;
		progressbar.SetActive (false);



	
	}

	// Update is called once per frame
	void Update () {



		if (Fade.loadscreeen == true) {

						if (test == false)
			{
								clear = true;

						StartCoroutine (DisplayLoadScreen ());
						test = true;
				}

			if(async.isDone)
				Debug.Log("Teste");
				}






	
	}

	IEnumerator DisplayLoadScreen ()
	{


		background.SetActive (true);
		text1.renderer.enabled = true;
		progressbar.SetActive (true);

		progressbar.transform.localScale = 
			new Vector3 (progressbar.transform.localScale.x, 
			             progressbar.transform.localScale.y, LoadProgress);
		text1.text = LoadProgress + "%";




		async = Application.LoadLevelAsync (2);

						while (!async.isDone) {
								LoadProgress = (int)(async.progress * 110);
								text1.text = LoadProgress + "%";
								progressbar.transform.localScale = 
				new Vector3 (progressbar.transform.localScale.x, 
				                                       
				             progressbar.transform.localScale.y, async.progress);

			yield return null;
							

						}








				



	}
}
