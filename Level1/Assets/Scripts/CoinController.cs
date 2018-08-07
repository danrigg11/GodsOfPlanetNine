﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	public int scoreValue = 10;

	void Update(){
		transform.Rotate (0, 0, 90 * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		ScoreController.score += scoreValue;
		Destroy (gameObject);
	}
}
