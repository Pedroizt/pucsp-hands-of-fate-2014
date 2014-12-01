using UnityEngine;
using System.Collections;

public class WaterTerrain : MonoBehaviour {

	/*O Script a seguir se trata do controle da agua do jogo*/

	/*As variaveis a seguir servem para pegar variaveis de outros scripts na inicializaçao*/
	private Hpsih health;
	private MotionBlur mb;

	//bool criada para controlar o estado do personagem.
	private bool InsideWater = false;

	void Start()
	{
		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.

		GameObject h = GameObject.Find ("Sihir");
		health = h.GetComponent<Hpsih> ();

		GameObject m = GameObject.Find ("RealCamera");
		mb = m.GetComponent<MotionBlur> ();
	}


	void OnTriggerEnter(Collider col)
	{
		//Caso o objeto de tag "Player" entre na trigger desse objeto, a bool InsideWater se tornara verdadeira.
		if (col.gameObject.tag == "Player") {

						InsideWater = true;
				}
	}

	void OnTriggerExit()
	{
		//Caso o jogador nao esteja mais na trigger de agua, a bool InsideWater voltara a ser false.
		InsideWater = false;

	}

	void Update()
	{
		/*Caso a bool InsideWater seja verdadeira, a personagem perdera metade de sua vida maxima por segundo. 
		 * aumentando assim o blur da camera.*/
		if (InsideWater == true) {
			health.curHealth -= health.maxHealth / 2 * Time.deltaTime;
			mb.blurAmount += 0.3f * Time.deltaTime;
				}
		//Caso essa bool seja falsa, o blur da cemera sera diminuido 0.1f por segundo
		if (InsideWater == false) {
			//Debug.Log("Teste");
						mb.blurAmount -= 0.1f * Time.deltaTime;
				}
	}
}
