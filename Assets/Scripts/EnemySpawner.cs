using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour{
	public GameObject enemySpawner;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		Instantiate (enemy, randomVector (enemySpawner), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Vector3 randomVector( GameObject enemySpawner ) {
		float sizeX = enemySpawner.transform.localScale.x / 2;
		float sizeY = enemySpawner.transform.localScale.y / 2;
		float sizeZ = enemySpawner.transform.localScale.z / 2;

		Vector3 randomPos = new Vector3( Random.Range( -sizeX, sizeX ),
			                  		     Random.Range( -sizeY, sizeY ),
			                  			 Random.Range( -sizeZ, sizeZ ));

		return randomPos;
	}

}
