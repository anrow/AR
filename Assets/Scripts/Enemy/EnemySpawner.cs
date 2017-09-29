using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	[SerializeField]
	public GameObject enemyPrefab;

	[SerializeField]
	public int enemyNum;

	[SerializeField]
	public GameObject cameraBox;

	private const int LEFT_SIZE = 0;
	private const int RIGHT_SIZE = 1;

	private const int MIN_SIZE = 0;
	private const int MAX_SIZE = 2;

	private float sizeX;
	private float sizeY;
	private float sizeZ;

	private float offsetX;
	private float offsetY;
	private float offsetZ;

	private Vector3 randomVector;

	int LeftOrRight( ) {
		return Random.Range( MIN_SIZE, MAX_SIZE );
	}

	float randX( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -sizeX, -offsetX );
		} 
			
		return Random.Range( offsetX, sizeX );

	}

	float randY( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -sizeY, -offsetY );
		} else {
			return Random.Range( offsetY, sizeY );
		}
	}

	float randZ( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -sizeZ, -offsetZ );
		} else {
			return Random.Range( offsetZ, sizeZ );
		}
	}

	// Use this for initialization
	void Start( ) {

		cameraBox = GameObject.FindWithTag( "CameraBox" );

		sizeX = this.transform.localScale.x / 2;
		sizeY = this.transform.localScale.y / 2;
		sizeZ = this.transform.localScale.z / 2;

		offsetX = cameraBox.transform.localScale.x / 2;
		offsetY = cameraBox.transform.localScale.y / 2;
		offsetZ = cameraBox.transform.localScale.z / 2;

		randomVector = new Vector3( randX( LeftOrRight( ) ), randY( LeftOrRight( ) ), randZ( LeftOrRight( ) ) );


		Instantiate( enemyPrefab, randomVector, Quaternion.identity );

	}
	
	// Update is called once per frame
	void Update( ) {
		

	}
		
}
