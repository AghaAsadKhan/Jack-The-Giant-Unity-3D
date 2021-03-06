﻿using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {


	private float speed = 1f;
	private float accelration = 0.2f;
	private float maxSpeed = 3.2f;
	[HideInInspector]
	public bool moveCamera;

	// Use this for initialization
	void Start () {

		moveCamera = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (moveCamera) {
		
			MoveCamera ();
		}
	}
		
	void MoveCamera()
	{
		Vector3 temp = transform.position;
		float oldY = temp.y;
		float newY= temp.y -(speed * Time.deltaTime);
		temp.y = Mathf.Clamp (temp.y, oldY, newY);

		transform.position = temp;
		speed += accelration * Time.deltaTime;
		if (speed > maxSpeed) {
			speed = maxSpeed;
		}
	}
	
	
}
