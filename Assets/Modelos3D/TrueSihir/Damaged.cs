using UnityEngine;
using System.Collections;

public class Damaged : MonoBehaviour
{
		//Esse script controla a cor da personagem ao tomar dano, ela necessita do script TrueSihir para funcionar.
		Color colorstart = Color.white; //Cor que a personagem começa.
		Color colorend = Color.red;//Cor a qual o material ira adquirir apos tomar dano.
		float duracao = 1.0f;//Quanto tempo durara essa transiçao.
		private TrueSihir sihir; //Para coletar componente.

		// Use this for initialization
		void Start ()
		{
				//Inicializar um componente para coletar o componente necessario.
				GameObject s = GameObject.Find ("Sihir");
				sihir = s.GetComponent<TrueSihir> ();
	
		}
	
		// Update is called once per frame
	//Temporizador para auxiliar no controle da cor.
	public float timed = 0;
		void Update ()
		{
				/*Caso a bool que esta no script seja acionada, o temporizador sera ativado e outra variavel e
				 * acionada para que a cor volte ao seu estado original depois de um tempo.
				 * A cor dela recebe uma transiçao para o vermelho e volta ao estado original graças ao Mathf.PingPong.
				 * Caso o temporizador tenha chegado a 0.8(Volta completa do branco-vermelho, vermelho-branco),
				 * ela diz para a variavel de TrueSihir que ela nao tomou dano e reseta o temporizador.*/
				if (sihir.damaged == true) {
						timed += Time.deltaTime;
						float lerp = Mathf.PingPong (timed, 0.4f);
						renderer.material.color = Color.Lerp (colorstart, colorend, lerp);
						if (timed>0.8f ) {
								sihir.damaged = false;
								timed = 0f;
								Debug.Log ("Teste");
						}
				}

				/*Caso a bool de dano da personagem esteja no falso, a cor dela continuara a ser a original.*/
				if (sihir.damaged == false) {
						renderer.material.color = Color.white;
				}
	
		}


}
