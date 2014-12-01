using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	//SCRIPT NAO UTILIZADO
	//MOTIVO: NAO DEU CERTO UM CONTROLE DE PAUSE FORA DA CLASSE.
	public void Paused()
	{
		Time.timeScale = 0;
	}

	public void UnPause()
	{
		Time.timeScale = 1;
	}

}
