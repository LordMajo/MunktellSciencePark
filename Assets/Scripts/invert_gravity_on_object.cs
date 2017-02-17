using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert_gravity_on_object : MonoBehaviour {
	
	public float thrust;
	public Rigidbody rb;
	// Use this for initialization
	void Start() 
	{
			
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
	}

	void FixedUpdate() 
	{
		rb.AddForce(0, 15f, 0 * thrust);
	}
}
