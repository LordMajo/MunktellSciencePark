using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_CO2 : MonoBehaviour {

	public GameObject[] COtwo;
	public int amount;
	public int limit;
	private Vector3 spawnPoint;
	// Update is called once per frame


	void Update () {
		COtwo = GameObject.FindGameObjectsWithTag("CO2");
		amount = COtwo.Length; 

		if (amount != limit) {
			InvokeRepeating ("SpawnCOtwo", 0, 0.2f);

		}
		
	}

	void SpawnCOtwo ()
	{
		spawnPoint.x = Random.Range (-10,10);
		spawnPoint.y = 1;
		spawnPoint.z = Random.Range (-10,10);

		Instantiate (COtwo [UnityEngine.Random.Range (0, COtwo.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}
}
