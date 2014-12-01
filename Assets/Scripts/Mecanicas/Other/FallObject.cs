using UnityEngine;
using System.Collections;

public class FallObject : MonoBehaviour {


	/*SCRIPT NÃO UTILIZADO
	MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	FUNÇAO: Seria um script que faria estalagmites cairem do teto quando o personagem chegar na trigger
	 Ao colidirem com algo, elas sao destruidas.*/
	void OnTriggerEnter(Collider col)
	{
		gameObject.rigidbody.useGravity = true;
	}

	void OnCollisionEnter(Collision collision)
	{
		Destroy (gameObject);
	
	}
}
