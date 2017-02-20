using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverVolume : MonoBehaviour {

	public float hoverForce = 12f;



	void OnTriggerEnter(Collider other) {
	
		Debug.Log ("Collision enter");

	}


	void OnTriggerExit(Collider other) {
		
		Debug.Log ("Collision exit");

	}


	void OnTriggerStay(Collider other) {
		
		Debug.Log ("Collision stay");
		other.GetComponent<Rigidbody>().AddForce (Vector3.up * hoverForce, ForceMode.Force);

	}

}
