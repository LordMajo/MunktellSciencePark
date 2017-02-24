using System.Collections;
using UnityEngine;

public class CollisionSound : MonoBehaviour {

	public AudioClip boing;
	private AudioSource source;

	void Awake() {

		source = GetComponent<AudioSource>();

	}


	void OnCollisionEnter(Collision coll) {
	
		source.PlayOneShot (boing, 0.5f);

	}

}
