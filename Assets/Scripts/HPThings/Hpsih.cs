using UnityEngine;
using System.Collections;

public class Hpsih : MonoBehaviour {

	public float maxHealth =  10f;
	public float curHealth =  10f;
	public float HealthRegen = 0.125f;
	public GameObject maxH;
	public GameObject AlmostMaxH;
	public GameObject HalfH;
	public GameObject AlmostEmptyH;
	public GameObject Empty;
	private Fade fd;
	private Inventario pause;
	public bool paused = false;
	private HistoriaControl history;
	private CutsceneControl cutsc;
	public bool Damaged = false;



	// Use this for initialization
	void Start () {

		GameObject f = GameObject.Find ("screenFader");
		fd = f.GetComponent<Fade> ();

		GameObject h = GameObject.Find ("OpeningHistory");
		history = h.GetComponent<HistoriaControl> ();

		GameObject i = GameObject.Find ("inventario 2");
		pause = i.GetComponent<Inventario> ();

		GameObject c = GameObject.Find ("Opening Cutscene");
		cutsc = c.GetComponent<CutsceneControl> ();


		maxH.SetActive (true);
		AlmostMaxH.SetActive (false);
		HalfH.SetActive (false);
		AlmostEmptyH.SetActive (false);
		Empty.SetActive (false);



	
	}
	
	// Update is called once per frame
	void Update () {

		if (curHealth != maxHealth && curHealth != 0f) {
			curHealth += HealthRegen * Time.deltaTime;
				}

		if (curHealth > maxHealth)
						curHealth = maxHealth;

		if (curHealth <= 0) {
						curHealth = 0;
			fd.gameOver = true;
				}

		if (Damaged == true) {
			Invencibilidade();
				}

		ReducaoHp ();
	
	}


	void ReducaoHp(){
	
		if (pause.isPause == false && history.começacutscene == true && cutsc.jogoinicia == true) {
						if (curHealth >= maxHealth || curHealth > maxHealth / 1.25f)
			{
				maxH.SetActive (true);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), maxH);

						if (curHealth <= maxHealth / 1.25 && curHealth > maxHealth / 2f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (true);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
			}

								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), AlmostMaxH);

						if (curHealth <= maxHealth / 2f && curHealth > maxHealth / 4f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (true);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), HalfH);

						if (curHealth <= maxHealth / 4f && curHealth > maxHealth / 10f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (true);
				Empty.SetActive (false);
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), AlmostEmptyH);

						if (curHealth <= maxHealth / 10f && curHealth >= 0f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (true);
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), Empty);
				}

		else
		{
			maxH.SetActive (false);
			AlmostMaxH.SetActive (false);
			HalfH.SetActive (false);
			AlmostEmptyH.SetActive (false);
			Empty.SetActive (false);
		}


	}

	void Invencibilidade()
	{
		StartCoroutine (Fimdainv ());
	}

	IEnumerator Fimdainv()
	{
		yield return new WaitForSeconds(1);
		Damaged = false;
	}



	/*IEnumerator HealthRegeneration()
	{


	}*/
}
