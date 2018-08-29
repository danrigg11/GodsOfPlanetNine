using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusCollider : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("ThirdPersonController").SendMessage ("Restart");
	}
}
