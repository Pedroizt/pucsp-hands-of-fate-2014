using UnityEngine;
using System.Collections;

public class MasterEnemyClass : MonoBehaviour {

	public float maxHealth;
	public float curHealth;
	public Texture maxH;
	public Texture AlmostMaxH;
	public Texture HalfH;
	public Texture AlmostEmptyH;
	public Texture Empty;
	public string nomedoinimigo = "";
	public bool toggleGui = false;
	public Hpsih HPPlayer;

	void OnMouseOver()
	{
		toggleGui = true;
		
	}
	
	void OnMouseExit()
	{
		toggleGui = false;
	}

	void Start()
	{
		GameObject g = GameObject.Find ("Senpai Notice Me");
		HPPlayer = g.GetComponent<Hpsih> ();
	}

	







	
}
