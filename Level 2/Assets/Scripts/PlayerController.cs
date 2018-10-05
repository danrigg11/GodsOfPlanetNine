using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	public float jumpforce;

	private Vector3 moveDirection;
	public float gravityScale;

	private CharacterController CC;

	void Start()
	{
		CC = GetComponent<CharacterController> ();
	}

	void Update()
	{
		moveDirection = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);

		if (Input.GetButtonDown ("Jump")) 
		{
			moveDirection.y = jumpforce;
		}

		moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
		CC.Move (moveDirection * Time.deltaTime);
	}
}
