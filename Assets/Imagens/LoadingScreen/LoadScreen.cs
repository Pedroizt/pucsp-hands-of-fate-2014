using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {


	//public string LeveltoLoad;

	public GameObject background;
	public TextMesh text1;
	public bool clear = false;
	public GameObject progressbar;

	private ScriptNovoJogo novojogo;
	private MenuFade Fade;
	private int LoadProgress = 0;



	// Use this for initialization
	void Start () {

		GameObject n = GameObject.Find ("NovoJogo");
		novojogo = n.GetComponent<ScriptNovoJogo> ();

		GameObject f = GameObject.Find ("screenfader");
		Fade = f.GetComponent<MenuFade> ();


		background.SetActive (false);
		text1.renderer.enabled = false;
		progressbar.SetActive (false);


	
	}

	// Update is called once per frame
	void Update () {

		if (Fade.loadscreeen == true) {
			Debug.Log("TestE");
			clear = true;
						StartCoroutine (DisplayLoadScreen ());
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




						AsyncOperation async = Application.LoadLevelAsync (2);
						while (!async.isDone) {
								LoadProgress = (int)(async.progress * 100);
								text1.text = LoadProgress + "%";
								progressbar.transform.localScale = 
				new Vector3 (progressbar.transform.localScale.x, 
			                                               
				             progressbar.transform.localScale.y, async.progress);
								yield return null;

						}
				



	}
}
