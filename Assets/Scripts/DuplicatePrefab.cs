using UnityEngine;

public class DuplicatePrefab : MonoBehaviour {

	public GameObject prefab;
	public int prefabCount;

	public float spawnOffsetHigh;
	public float spawnOffsetLow;
	public float dropHeight;
	private int i;



	void Update() {
		
		if (i < prefabCount) {
		
			Instantiate(prefab, new Vector3(Random.Range(spawnOffsetLow, spawnOffsetHigh), dropHeight+i, Random.Range(spawnOffsetLow, spawnOffsetHigh)), Quaternion.identity);
			i++;
		}


	}

}
