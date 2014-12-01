using UnityEngine;
using System.Collections;

public class CrystalSwitch : MonoBehaviour {


	//Este script e o script utilizado nas "Switches" da primeira fase.

	bool EstaSwitch = false; //bool feita pra controlar as switches, sendo ativada apenas quando o jogador se aproximar dela.
	bool naofucionamais = false;//bool criada para desativar o uso da switch apos ela ser ativada.
	public float vel = 2.0f; //Velocidade da rotaçao do cristal durante o tempo de vida dela.

	private CristalGrande cgrande; //Variavel da classe CristalGrande
	public GameObject F; //GameObject que armazena a imagem "F" usada para mostrar ao jogador que tecla apertar ao chegar proximo a switch.

	// Use this for initialization
	void Awake () {

		//O objeto e inicializado com a cor vermelha.
		gameObject.renderer.material.color = Color.red; 



		//O GameObject F esta desativado na inicializaçao
		F.SetActive (false);

		//Ao ser inicializado, o script procurara o objeto e obtera o script desse objt.
		GameObject c = GameObject.Find ("CristalGrande");
		cgrande = c.GetComponent<CristalGrande> ();
	
	}
	
	// Update is called once per frame
	void Update () {

				//Rotaçao do cristal durante seu tempo de vida, usando a variavel ja declarada vel.
				transform.Rotate (0, vel, 0);
		        
					
				

	
				}
		

	//Quando o jogador chegar proximo da switch e ficar em sua colisao, essa bool sera ativada.
	 void OnTriggerStay(Collider col){
		EstaSwitch = true;



		/*Quando tal bool for ativada e quem chegar perto for um objeto de tag "Player",
		 * Aparecera a o objeto F. Ao teclar F (ou o B do controle do XBOX, ambos controlados via botao
		 * Trigger, setado no Input da Unity, o objeto mudara a cor para o azul, recebera uma tag "On", 
		 * executara o Start do script do CristalGrande (Para checar quantas vezes isso ja foi feito),
		 * mudara a velocidade do cristal para 0 e finalmente desativara o GameObject F*/
		if(col.gameObject.tag == "Player" && EstaSwitch == true)
		{


			if (Input.GetButtonDown("Trigger")&& naofucionamais == false)
			{
			
			gameObject.renderer.material.color = Color.blue;
			gameObject.tag = "On";
			cgrande.Start ();

			
			naofucionamais = true;
			vel = 0;
				F.SetActive(false);





		}
			if (naofucionamais == false)
				F.SetActive(true);






	}
}

	//Caso o jogador nao esteja na area da trigger da switch, prevenindo que ela seja executada e o GameObject F apareça.
	void OnTriggerExit(){
		EstaSwitch = false;
		F.SetActive (false);

	}





}

