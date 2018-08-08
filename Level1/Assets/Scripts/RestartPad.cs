using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPad : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("ThirdPersonController").SendMessage ("Restart");
	}
}
