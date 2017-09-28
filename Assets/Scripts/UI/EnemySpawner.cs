using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour{
	[SerializeField]
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		//Instantiate (enemy, randomVector( ),Camera.main.transform.rotation);
		//Instantiate (enemy, new Vector3(-1, -1, 5), Quaternion.identity);
		Instantiate (enemy, this.transform.localPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Vector3 randomVector( ) {
		float sizeX = this.transform.localScale.x / 2;
		float sizeY = this.transform.localScale.y / 2;
		float sizeZ = this.transform.localScale.z / 2;

		Vector3 randomPos = new Vector3( Random.Range( -sizeX, sizeX ),
			                  		     Random.Range( -sizeY, sizeY ),
			                  			 Random.Range( -sizeZ, sizeZ ));

		return randomPos;
	}

}
