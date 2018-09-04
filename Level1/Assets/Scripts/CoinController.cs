using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	public int scoreValue = 10;


	void Update(){
		transform.Rotate (0, 0, 90 * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		//ScoringSystem.number += scoreValue;
		Destroy (gameObject);
		//StartCoroutine (startTimer());
	}

	//IEnumerator startTimer()
	//{
	//	yield return new WaitForSeconds (.6f);
	//	Destroy (gameObject);
	//
	//}
}
