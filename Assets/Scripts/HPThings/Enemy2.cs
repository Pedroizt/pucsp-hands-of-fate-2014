using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

	public float thismaxH = 50f;
	public float thiscurH = 50f;
	public float damage = 2f;
	public string thisname;
	/*public Texture maxH;
	public Texture AlmostMaxH;
	public Texture HalfH;
	public Texture AlmostEmptyH;
	public Texture Empty;*/
	bool toggleGui;
	public bool SmInv = true;
	public MasterEnemyClass mec;
	public SpawnRespawn sr;

	// Use this for initialization
	void Start () {

		GameObject _mec = GameObject.Find ("Mast");
		mec = _mec.GetComponent<MasterEnemyClass> ();


		GameObject _sr = GameObject.Find ("SpawnPoint2");
		sr = _sr.GetComponent<SpawnRespawn> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		EnemyKilled ();
		mec.maxHealth = thismaxH;
		mec.curHealth = thiscurH;
		mec.nomedoinimigo = thisname;

	
	}
	void OnMouseOver()
	{
		toggleGui = true;

		
	}

	void OnMouseExit()
	{
		toggleGui = false;
		}

	void OnGUI()
	{
		if (toggleGui == true)
			DrawBar();
	}

	void EnemyKilled()
	{
		if (thiscurH <= 0) {
			thiscurH = 0;
			sr.EnemyDead = true;
		}
	}

	void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.tag == "Player" && SmInv == true ) {
			mec.HPPlayer.curHealth -= damage;
			bool isDamaged = true;
			if (isDamaged)
				StartCoroutine(InvFrames());
		}
		
		
	}
	
	IEnumerator InvFrames()
	{
		SmInv = false;
		yield return new WaitForSeconds (2);
		SmInv = true;
		
	}
	void DrawBar()
	{


		thisname = "Esfera";

		thisname = GUI.TextField (new Rect (Screen.width - 760, Screen.height - 450, 50, 50), thisname, "Label");


		if (thiscurH >= thismaxH || thiscurH > thismaxH / 1.25f)
			GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 480, 30, 50), mec.maxH);

		
		if (thiscurH <= thismaxH / 1.25 && thiscurH > thismaxH / 2f)
			GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 480, 30, 50), mec.AlmostMaxH);
		
		if (thiscurH <= thismaxH / 2f && thiscurH > thismaxH / 4f)
			GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 480, 30, 50), mec.HalfH);
		
		if (thiscurH <= thismaxH / 4f && thiscurH > thismaxH / 10f)
			GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 480, 30, 50), mec.AlmostEmptyH);
		
		if (thiscurH <= thismaxH / 10f && thiscurH >= 0f)
			GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 480, 30, 50), mec.Empty);
	}

}
