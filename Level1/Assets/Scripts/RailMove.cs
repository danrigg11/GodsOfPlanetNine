using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailMove : MonoBehaviour 
{
	public Rail rail;
	public Transform lookAt;
	public bool smoothMove = true;
	public float moveSpeed = 5.0f;

	private Transform thisTransform;
	private Vector3 lastPosition;

	// Use this for initialization
	private void Start () 
	{
		thisTransform = transform;
		lastPosition = thisTransform.position;
	}
	
	// Update is called once per frame
	private void Update () 
	{
		if (smoothMove) 
		{
			lastPosition = Vector3.Lerp (lastPosition, rail.ProjectPositionOnRail (lookAt.position),moveSpeed * Time.deltaTime);
			thisTransform.position = lastPosition;
		} 
		else 
		{
			thisTransform.position = rail.ProjectPositionOnRail (lookAt.position);
		}
		thisTransform.LookAt (lookAt.position);
	}
}
