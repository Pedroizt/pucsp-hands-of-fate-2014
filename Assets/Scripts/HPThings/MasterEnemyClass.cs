using UnityEngine;
using System.Collections;

public class MasterEnemyClass : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: NAO FUNCIONAMENTO DE UMA CLASSE QUE CONTROLA TODOS OS INIMIGOS. SUBSTITUIDO POR OUTROS SCRIPTS.
	 * FUNÇAO: A funçao original era controlar todos os atributos dos inimigos.*/
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
		GameObject g = GameObject.Find ("Sihir");
		HPPlayer = g.GetComponent<Hpsih> ();
	}

	







	
}
