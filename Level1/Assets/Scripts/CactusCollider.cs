using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusCollider : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		coinCounter.coins = 0;
		GameObject.Find ("ThirdPersonController").SendMessage ("Restart");
	}
}
