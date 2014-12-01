using UnityEngine;
using System.Collections;

public class CriarLuz : MonoBehaviour {


	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA/TERCEIRA FASE.
	 * FUNÇAO: Criar o projetil do feitiço de luz.*/
	bool noluz = false;
	public Object ob;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (noluz==false && Input.GetKeyDown(KeyCode.F)) {
			noluz = true;
			Object c = Instantiate (ob, transform.position, transform.rotation);
			Destroy(c,1);
			noluz = false;

		}


	
	}
}
