using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour{
	[SerializeField]
	public GameObject enemyPrefab;

	[SerializeField]
	public GameObject cameraBox;


	float sizeX = this.transform.localScale.x / 2;
	float sizeY = this.transform.localScale.y / 2;
	float sizeZ = this.transform.localScale.z / 2;

	// Use this for initialization
	void Start () {

		cameraBox = GameObject.FindWithTag( "CameraBox" );


		Instantiate( enemyPrefab, randomVector( ), Quaternion.identity );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	float randX( ) {
		return Random.Range( -sizeX, sizeX );
	}
	float randY( ) {
		return Random.Range( -sizeY, sizeY );
	}
	float randZ( ) {
		return Random.Range( -sizeZ, sizeZ );
	}

	Vector3 randomVector( ) {

		float offsetX = cameraBox.transform.localScale.x / 2;
		float offsetY = cameraBox.transform.localScale.y / 2;
		float offsetZ = cameraBox.transform.localScale.z / 2;



		//float randX = Random.Range( -sizeX, sizeX );
		//float randY = Random.Range( -sizeY, sizeY );
		//float randZ = Random.Range( -sizeZ, sizeZ );


		Vector3 randomPos = new Vector3( randX, randY, randZ );
	
		return randomPos;
	}



}
