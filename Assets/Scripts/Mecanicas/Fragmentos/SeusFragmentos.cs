using UnityEngine;
using System.Collections;

public class SeusFragmentos : MonoBehaviour {

	//Classe para armazenar quantos fragmentos de memoria voce tem.
	public int SihFrags = 0;
	public int AurFrags = 0;
	public int HistFrags = 0;
	public int MythFrags = 0;

	public GameObject SPrologo;
	public GameObject SInterrogacaoP;
	public GameObject SCap1;
	public GameObject SInterrogacao1;
	public GameObject SCap2;
	public GameObject SInterrogacao2;
	public GameObject SCap3;
	public GameObject SInterrogacao3;
	public GameObject SCap4;
	public GameObject SInterrogacao4;
	public GameObject SEpilogo;
	public GameObject SInterrogacao1E;

	void Update()
	{
		if (SihFrags == 1) {
						SInterrogacaoP.SetActive (false);
						SPrologo.SetActive(true);
				}

	}

}
