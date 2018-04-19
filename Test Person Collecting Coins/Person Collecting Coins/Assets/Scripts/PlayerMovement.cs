using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	// Access the player Rigidbody
	private Rigidbody rb;

	// Placeholder for thrust in Fixed Update
	private float speed = 10.0f;
	private float rotationSpeed = 10.0f;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate() 
	{
		float verticalMovement = Input.GetAxis ("Vertical") * speed;
		float horizontalMovement = Input.GetAxis ("Horizontal") * rotationSpeed;

		rb.AddForce (horizontalMovement, 0, verticalMovement);
	}
}
