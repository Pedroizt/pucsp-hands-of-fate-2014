using UnityEngine;
using System.Collections;

public class mapa : MonoBehaviour {

	public GameObject map;
	public GameObject[] nuvens;
	public Inventario invent;
	bool ismap = false;

	public GameObject[] triggers;

	bool notcloud1 = false;
	bool notcloud2 = false;
	bool notcloud3 = false;
	bool notcloud4 = false;


	// Use this for initialization
	void Start () {

		map.renderer.enabled = false;
		nuvens[0].renderer.enabled = false;
		nuvens[1].renderer.enabled = false;
		nuvens[2].renderer.enabled = false;
		nuvens[3].renderer.enabled = false;



	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.M))
		{

			Time.timeScale = 0;
			ismap = !ismap;
			if (ismap == true)
				DrawMap();
		}

		if (ismap == false) {
						DontDrawMap ();
			Time.timeScale = 1;
				}

	
	}

	void DrawMap()
	{
		map.renderer.enabled = true;

		if (notcloud1 == false)
		nuvens[0].renderer.enabled = true;
		if (notcloud2 == false)
		nuvens[1].renderer.enabled = true;
		if (notcloud3 == false)
		nuvens[2].renderer.enabled = true;
		if (notcloud4 == false)
		nuvens[3].renderer.enabled = true;
	}

	void DontDrawMap()
	{
		map.renderer.enabled = false;

			nuvens[0].renderer.enabled = false;

			nuvens[1].renderer.enabled = false;

			nuvens[2].renderer.enabled = false;

			nuvens[3].renderer.enabled = false;
	}

	void DonDrawCloud1()
	{
		Debug.Log ("Teste");
		notcloud1 = true;
	}
	void DonDrawCloud2()
	{
		notcloud2 = true;
	}
	void DonDrawCloud3()
	{
		notcloud3 = true;
	}
	void DonDrawCloud4()
	{
		notcloud4 = true;
	}



}
