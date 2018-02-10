using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	
	[SerializeField]
	public GameObject enemyPrefab;

	[SerializeField]
	public GameObject BossPrefab;

	[SerializeField]
	public GameObject cameraBox;

	[SerializeField]
	public PowerCageController m_PowerCageController;

	[SerializeField]
	public int enemyCount;

	private const int LEFT_SIZE = 0;
	private const int RIGHT_SIZE = 1;

	private const int MIN_SIZE = 0;
	private const int MAX_SIZE = 2;

	private float spawn_pos_x;
	private float spawn_pos_y;
	private float spawn_pos_z;

	private float offset_x;
	private float offset_y;
	private float offset_z;

	private Vector3 randomVector;

	int LeftOrRight( ) {
		return Random.Range( MIN_SIZE, MAX_SIZE );
	}

	float randX( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -spawn_pos_x, -offset_x );
		} 
			
		return Random.Range( offset_x, spawn_pos_x );

	}

	float randY( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -spawn_pos_y, -offset_y );
		} else {
			return Random.Range( offset_y, spawn_pos_y );
		}
	}

	float randZ( int whichSize ) { 
		if ( whichSize == LEFT_SIZE ) {
			return Random.Range( -spawn_pos_z, -offset_z );
		} else {
			return Random.Range( offset_z, spawn_pos_z );
		}
	}

	void Awake( ) {
		this.enabled = false;
	}

	// Use this for initialization
	void Start( ) {
		
		enemyCount = 0;

		StartCoroutine( Spawn( enemyCount ) );
		
	}
	
	// Update is called once per frame
	void Update( ) {
		
		if ( m_PowerCageController.IsCageReday( ) ) {
			Invoke( "BossShow", 3f );
		}
	}

	private IEnumerator Spawn( int count ) {

		const int MAX_COUNT = 20;

		count = 0;

		while ( count < MAX_COUNT ) {
			cameraBox = GameObject.FindWithTag( "CameraBox" );

			spawn_pos_x = this.transform.localScale.x / 2;
			spawn_pos_y = this.transform.localScale.y / 2;
			spawn_pos_z = this.transform.localScale.z / 2;

			offset_x = cameraBox.transform.localScale.x / 2;
			offset_y = cameraBox.transform.localScale.y / 2;
			offset_z = cameraBox.transform.localScale.z / 2;

			randomVector = new Vector3( randX( LeftOrRight( ) ), randY( LeftOrRight( ) ), randZ( LeftOrRight( ) ) );


			Instantiate( enemyPrefab, randomVector, Quaternion.identity );

			count++;

			yield return new WaitForSeconds( 0.5f );
		}
	}

	private void BossShow( ) {

		Transform m_Cam = GameObject.FindGameObjectWithTag( "MainCamera" ).transform;

		Instantiate( BossPrefab, Camera.main.transform.forward * 10, m_Cam.rotation );
	}
		
}
