using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	void Update(){
		transform.Rotate (90 * Time.deltaTime, 0, 0);
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("ThirdPersonController").SendMessage ("Restart");
	}
}
