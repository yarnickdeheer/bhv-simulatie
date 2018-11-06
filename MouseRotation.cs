﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
	public float sensitivity = 10f;

	public float maxYAngle = 80f;

	public Vector2 currentRotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
		currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
		currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
		currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
		Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
		
	}
}
