using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour
{


	//O script a seguir se trata da classe mestra da mecanica do jogo.

		public TextMesh spelltext; //Armazenamento do texto para que ele apareça acima do personagem.
		public Transform cameratarget;//Para que a direçao do feitiço esteja alinhada com a posiçao da camera.
		public string espaço = ""; //Armazena os comandos que foram pressionados no jogo.
		public string selo;//Armazena o que a variavel espaço criou.
		private Inventario pause;//Controle para que nao seja utilizado enquanto o jogo esta pausado.
		//public Transform trsihir;

		/*Auxiliam para melhorar a jogabilidade no controle de XBOX, fazendo com que os comandos
		 * nao sejam usados de maneira incontrolavel*/
		bool already_pressed;
		public float counter = 0;
		




		// Use this for initialization
		void Start ()
		{
				//Coletar variavel de outro script.
				GameObject i = GameObject.Find ("inventario 2");
				pause = i.GetComponent<Inventario> ();

				//Controle para que os botoes nao sejam usados tao rapidamente (XBOX Apenas)
				already_pressed = false;
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				//Caso o jogo nao esteja pausado, ira executar esses metodos)
				if (pause.isPause == false) {
						spellnumbers ();
						spellarrows ();
						showtext ();
						spellcolors ();
				}

				gameObject.transform.rotation = cameratarget.transform.rotation;


				if (already_pressed) {

						counter += Time.deltaTime;
						if (counter >= 0.4f) {

								already_pressed = false;
								counter = 0;
						}

				}
			
		}

		//Armazena que comandos podem ser colocados na variavel espaço.
		void spellnumbers ()
		{
				if (Input.GetKeyDown (KeyCode.Keypad0) || (Input.GetKeyDown (KeyCode.Alpha0))) {
						espaço += "0";
				} else if (Input.GetKeyDown (KeyCode.Keypad1) || (Input.GetKeyDown (KeyCode.Alpha1))) {
						espaço += "1";
				} else if (Input.GetKeyDown (KeyCode.Keypad2) || (Input.GetKeyDown (KeyCode.Alpha2))) {
						espaço += "2";
				} else if (Input.GetKeyDown (KeyCode.Keypad3) || (Input.GetKeyDown (KeyCode.Alpha3))) {
						espaço += "3";
				} else if (Input.GetKeyDown (KeyCode.Keypad4) || (Input.GetKeyDown (KeyCode.Alpha4))) {
						espaço += "4";
				} else if (Input.GetKeyDown (KeyCode.Keypad5) || (Input.GetKeyDown (KeyCode.Alpha5))) {
						espaço += "5";
				} else if (Input.GetKeyDown (KeyCode.Keypad6) || (Input.GetKeyDown (KeyCode.Alpha6))) {
						espaço += "6";
				} else if (Input.GetKeyDown (KeyCode.Keypad7) || (Input.GetKeyDown (KeyCode.Alpha7))) {
						espaço += "7";
				} else if (Input.GetKeyDown (KeyCode.Keypad8) || (Input.GetKeyDown (KeyCode.Alpha8))) {
						espaço += "8";
				} else if (Input.GetKeyDown (KeyCode.Keypad9) || (Input.GetKeyDown (KeyCode.Alpha9))) {
						espaço += "9";
				} else if (espaço.Length >= 7) {
			
						espaço = "";
				} else if (Input.GetButtonDown ("Backspace")) {
			
						espaço = "";
				} 

				//Caso o botao listado seja acionado, a informaçao armazenada na variavel sera enviada
				//para a variavel selo.
				if (Input.GetButtonDown ("Cast"))
		    
						FinishMagic ();

		}

		//O mesmo do metodo acima, mas apenas usado para controle de XBOX.
		public void spellarrows ()
		{
				if (!already_pressed) {

						if (Input.GetAxis ("DPad Horizontal") > 0.1f) {
								espaço += "R ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Horizontal") < -0.1f) {
								espaço += "L ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Vertical") > 0.1f) {
								espaço += "U ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Vertical") < -0.1f) {
								espaço += "D ";
								already_pressed = true;
						}
						
				}

		}

		//Explicado anteriormente, a variavel espaço e resetada para que o jogador 
		//possa colocar novos comandos nela.
		public void FinishMagic ()
		{

				selo = espaço;
				espaço = "";
		
		}

		//O spelltext atualizara constantemente quando um novo comando for adicionado na variavel espaço.
		void showtext ()
		{
				
				if (spelltext == null)
						Debug.Log ("Esqueceu de colocar o SpellText");

				spelltext.text = espaço;
				

		}

		/*void showarrows{
		
}*/
		//Caso algum desses comandos estejam na variavel espaço, o spelltext mudara de cor, caso contrario,
		//ele sempre sera vermelho.
		void spellcolors ()
		{
				
				if (espaço == "01" || espaço == "83" || espaço == "10" || espaço == "D R " || espaço == "U L "
		    || espaço == "R D ")
						spelltext.color = Color.blue;
				else
						spelltext.color = Color.red;
				
		}



			


	
}


