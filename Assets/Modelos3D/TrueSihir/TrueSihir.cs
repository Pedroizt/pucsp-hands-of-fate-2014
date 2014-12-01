using UnityEngine;
using System.Collections;

public class TrueSihir : MonoBehaviour
{

	//O script a seguir se trata de toda movimentaçao da personagem.


		public float vel; //bool feita para auxiliar na velocidade de aumentar o personagem.
		public bool damaged = false;//bool feita para usar caso a personagem tenha recebido dano ou nao.
		public bool attacking;//bool utilizada para verificar se a personagem esta atacando.
		public bool nojump;//bool utilizada para verificar o pulo da personagem.
		public Animator anim;//varivel que armazena o animator da personagem.
		public float jumpforce = 7;//Força do pulo da personagem.
		public float speed = 10;//Tambem auxilia na velocidade do personagem e da animaçao.
		public float resetspeed = 7;//Utilizado para retornar a velocidade original do personagem.
		float progressivespeed = 0.2f;//Armazena a velocidade que ela ganhara indo para frente. Modificada futuramente.
		float resetprogressivespeed = 0.2f;//Armazena a velocidade progressiva original da personagem.
		public GameObject camera;//Armazena a camera que segue o personagem.
		private Rigidbody rb;//Variavel que permite a modificaçao do rigidbody da personagem.
		//public audioplay SihirSounds;
		public float pos;//Utilizada para modificar o eixo da personagem, fazendo possivel ela virar.
		bool walking;//checar se a personagem esta andando.
		bool sidewalk;//caso ela esteja andando na lateral.
		bool jumped = false;//outra bool de controle de pulo.

	/*As variaveis abaixo controlam o Animator dos dados que giram em torno da personagem*/
		public Animator dado1;
		public Animator dado2;
		public Animator dado3;
		public Animator dado4;

		public bool collided; //bool que checa se houve colisao com algo.
		public ParticleSystem bursts;//Particle system que controla os "bursts" que saem dos dados apos o comando de ataque.
		float cd; //Variavel que auxilia no controle do collided.
		bool pressedS;//Caso a tecla S seja acionada.
		bool pressedW;//Caso a tecla W seja acionada.

		public SihirSounds SihirSounds; //Objeto que armazena os sons da personagem.
		int randomnumber;//Variavel necessaria para que ela comece a rir aleatoriamente.
		public bool counterEnable = false; //Auxilia para que o som de passos seja tocado corretamente.
		public float counter_f = 0.4f;	//O mesmo do anterior.
		public bool jumpsound;//bool usada para auxiliar o som de pulo.
		public float counter2 = 0;//Variavel necessaria para que ela comece a rir aleatoriamente.

		//As variaveis abaixo foram utilizadas no controle de sons.
		bool already_running = false;
		bool already_jumping = false;
		float counter_j;

		// Use this for initialization
		void Start ()
		{
		//O gameobject a seguir foi inicializado para conseguir componente de outro script utilizando
		//a variavel ja declarada.
				GameObject a = GameObject.Find ("Sihir");
				SihirSounds = a.GetComponent <SihirSounds> ();


				rb = GetComponent<Rigidbody> ();//Para que a variavel consiga armazenar o Rigidbody do objeto.
				pos = 0f;//o pos começara no 0.
				pos = transform.localEulerAngles.y;//E sera igual ao Y do objeto.
		 		jumpsound = true;//bool para controlar o som de pulo.

				
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{

		//o contador começa e iniciado.
		counter2 += Time.deltaTime;

		#region Som Risada

		//Caso o random number seja igual ao "666", tocara o som de risada".
		if (counter2 >= 30) 
		{
			randomnumber = Random.Range (1, 6000);
			if (randomnumber == 666) {

				SihirSounds.PlaySound (2);
				counter2 = 0;

			}
		}
		#endregion

		//Para auxiliar no som de passos.
		#region Contador Passos
		if (counterEnable) 
		{
			if (counter_f >= 0.4f)
			{
				counter_f = 0;
				
			}
			counter_f += Time.deltaTime;
			
			
		}
		#endregion

		//
				walking = false;

				banwalking ();

		/* Da linha 112, ate a linha 239 descreve toda a movimentaçao da personagem. Ao personagem ir para frente
		 * sua animaçao de corrida sera ativada junto com os sons de passo, e a velocidade de sua animaçao aumentara progressivamente.
		 * Caso outra direçao adjacente seja acionada, o POS sera modificado fazendo com que a personagem va para a diagonal.
		 * Caso o jogador acione a esquerda ou direita, o pos virara 90 e o personagem ira apenas de lado.
		 * Ela so andara para frente ou para os lados enquanto ela nao estiver atacando (attacking == false), caso o comando para tras esteja acionado
		 * (PressedS = false) ou caso ela tenha colidido com algo (collided == false). Caso o jogador solte o comando de ir para frente
		 o pos retornara a ser lentamente 0.*/

				if (Input.GetAxis("Vertical") > 0.1f && 
		    attacking == false && pressedS == false && collided == false) {

						
		
						
						//if(already_running == false)
						//{
							FootstepsSound();
						//	already_running=true;	
						//}
						anim.SetBool ("_run", true);
						pressedW = true;		
								
						gameObject.transform.position += transform.forward * speed * Time.deltaTime;
						speed += progressivespeed * Time.deltaTime;


						
						anim.speed = speed / 6.5f;
						

						
						

						if (speed > 11)
								progressivespeed = 0;
						  
			
						
			
				} else {
						anim.SetBool ("_run", false);
						speed = resetspeed;

						SihirSounds.StopFootsteps();
						already_running=false;
						anim.speed = speed / 10f;
						progressivespeed = 0.1f;
				
			
		}


		if (Input.GetAxis("Horizontal") > 0.1f && Input.GetAxis("Vertical") > 0.1f && pressedS == false) {
						walking = true;
						if (pos < 45f)

								pos += 5f * Time.deltaTime * vel;
						
								
				 
				}

		if (Input.GetAxis("Horizontal") > 0.1f && attacking == false && pressedS == false) {

						if (walking == false) {

								//if(already_running == false)
								//{
									FootstepsSound();
								//	already_running=true;	
								//}
								anim.SetBool ("_run", true);
								pos = 90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;
								sidewalk = true;
								
							
						

						}


		} else{

				//SihirSounds.StopFootsteps();
				already_running = false;

			}

		if (Input.GetAxis("Horizontal") < -0.1f && Input.GetAxis("Vertical") > 0.1f&& pressedS == false) {
						walking = true;
						if (pos >= -45f)

								pos -= 5f * Time.deltaTime * vel;
				}

		if (Input.GetAxis("Horizontal") < -0.1f && attacking == false && pressedS == false) {
			
						if (walking == false) {
								//if(already_running == false)
								//{
									FootstepsSound();
								//	already_running=true;	
								//}
								anim.SetBool ("_run", true);
								pos = -90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;
								

				
						}
				} else {
				
								
								//SihirSounds.StopFootsteps();
								already_running = false;
				
				}

				/*if (pos != 0 && Input.GetKey (KeyCode.W) && walking == false) {
			pos = 0;
				}*/

		if (Input.GetAxis("Vertical") > 0.1f) {
						if (pos >= 0f && walking == false)
								pos -= 1f * Time.deltaTime * vel * 2;


						if (pos <= 0f && walking == false)
								pos += 1f * Time.deltaTime * vel * 2;
		
				}



				
		
		 		
		/*As linhas abaixo sao as principais e talvez as mais importantes do codigo.
		 * Ele controla a rotaçao da personagem usando a rotaçao da camera, caso pos seja maior ou menor que 0
		 * ele adicionara o mesmo na rotaçao do personagem, fazendo com que ela vire sem estar necessariamente de costas
		 * pra camera*/
				transform.localEulerAngles = 
			new Vector3 (transform.localEulerAngles.x, 
		                                         
			     camera.transform.localEulerAngles.y + pos
		                                         , transform.localEulerAngles.z);


				
		/*Caso o botao de pulo seja acionado (No caso o Space ou o "A" do controle do XBOX), Ela recebera 
		 * uma força que a levantara para cima, que sera multiplicada pela variavel Jumpforce. As bools "nojump" e 
		 * "jumped" se tornam false e true respectivamente. A gravidade sera desligada brevemente, a velocidade de animaçao
		 * da animaçao e do transform.forward sera cortada pela metade, tornado ela muito mais lenta no ar, prevenindo
		 * que quebre o jogo com grandes saltos. O som de pulo e executado tambem. Caso ela nao esteja pulando mais, ou tenha chegado ao chao
		 sua gravidade volta a ser verdadeira.*/
				if (Input.GetButtonDown("Jump")) {
						if (nojump == true) {
								nojump = false;
								jumped = true;
								rb.AddForce (Vector3.up * jumpforce, ForceMode.VelocityChange);
								anim.SetTrigger ("_jump");
								rb.useGravity = false;
								speed = speed / 2;
								already_jumping = true;
								#region Jump Sounds Switch
								if (jumpsound) {
										SihirSounds.PlaySound (3);
										jumpsound = false;
								} else {
										SihirSounds.PlaySound (4);
										jumpsound = true;
								}
								#endregion
						} 
				}else {
						
								rb.useGravity = true;						}

				/*
				if (Input.GetKeyDown (KeyCode.F)) {
						if (attacking == false)
								Attack ();
				}*/

				
				//Abaixo estao as condiçoes para que a personagem ande de costas e ande de costas diagonalmente,
		//a velocidade da personagem e cortada pela metade ao andar de costas.
				if (Input.GetAxis("Vertical") < -0.1f && pressedW == false) {

						anim.SetBool ("_run", true);
						gameObject.transform.position -= transform.forward * Time.deltaTime * speed / 2;
						pressedS = true;

				}

		if (Input.GetAxis("Vertical") < -0.1f && pressedS == true && Input.GetAxis("Horizontal") > 0.1f) {

			if (pos > -45f)
				
				pos -= 5f * Time.deltaTime * vel;
			
			
			
		}

		if (Input.GetAxis("Vertical") < -0.1f && pressedS == true && Input.GetAxis("Horizontal") < -0.1f) {

			if (pos < 45f)
				
				pos += 5f * Time.deltaTime * vel;
			
			
			
		}

		if (Input.GetAxis("Vertical") < -0.1f) {
						pressedS = true;
						pressedW = false;
				}

		if (Input.GetAxis ("Vertical") > 0.1f) {
						pressedW = true;
						pressedS = false;
				}
				

						
				
		}


	/*Caso a personagem esteja em contato com o terreno, nojump ficara verdadeira caso a bool de jumped 
	 * (assumindo que a personagem pulou) seja true, ao chegar ao chao, a animaçao de landing sera executada. 
	 * Fazendo com que ela nao pule duas vezes. A velocidade
	 da personagem volta ser a original, */
		void OnCollisionEnter (Collision col)
		{

						
				

				if (col.gameObject.tag == "Terrain") {
						nojump = true;
						if (jumped == true)
				anim.SetTrigger("_grounded");
			speed = resetspeed;
			    //anim.SetBool("_grounded", false);
						

				


						
						
						
				}

		//caso ela colide com algum objeto que nao tenha tag, ela sera jogada levemente para tras, acionando a bool collided e disparando uma Coroutine.
		if (col.gameObject.tag == "Untagged"){
			
			Debug.Log ("Collided");
			gameObject.transform.position -= transform.forward * 0.5f;
			collided = true;
			StartCoroutine(colcd());


		}


		
		

		}

		/*void OnCollisionExit (Collision col)
		{
				Debug.Log ("NotGrounded");
					
				//jumped = true;
		}*/

		/*Metodo utilizado para quando ela receber a mensagem de ataque. Disparando uma Coroutine, acionando a bool attacking
		 * tocando os bursts e acionando a animaçao de ataque.*/
		void Attack ()
		{
				anim.SetTrigger ("_attack");
				attacking = true;
				StartCoroutine (boolback ());
				dado1.SetTrigger ("attack");
				dado2.SetTrigger ("attack2");
				dado3.SetTrigger ("attack3");
				dado4.SetTrigger ("attack4");
				bursts.Play ();


		}

		//caso ela tenha recebido a mensagem de dano, a bool damaged sera verdadeira. (Usada tambem no script
	// "Damaged");
		void Damage()
		{
		damaged = true;
		Debug.Log ("Correct");
		}

		//Coroutine que tem como objetivo voltar o estado original da bool;
		IEnumerator boolback ()
		{
				yield return new WaitForSeconds (1.8f);
				attacking = false;
		}
		
		//Coroutine que tem como objetivo voltar o estado original da bool;
		IEnumerator colcd()
		{
		yield return new WaitForSeconds(1);
		collided = false;
		}
	
	
		
		//Abaixo estao os metodos que auxiliam na reproduçao dos sons.
		void FootstepsSound()
		{
			if (counter_f >= 0.39f) 
			{
				SihirSounds.Footstep_Sound();
				counterEnable = true;
			}
		}
	

		void banwalking () 
		{
			
			if (already_jumping) 
			{

			counter_j += Time.deltaTime;
			SihirSounds.MuteFootsteps();
			if(counter_j >= 1)
			{

				SihirSounds.UnMuteFootsteps();
				counter_j = 0;
				already_jumping = false;

			}
			}

		}
		/*void progressivespeed()
	{
		while (speed < 5)
						speed += 0.2f * 0.01f * Time.deltaTime;
	}*/


	
}



