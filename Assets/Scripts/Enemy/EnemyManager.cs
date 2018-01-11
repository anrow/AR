using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	
	[SerializeField]
	public GameObject[ ] enemys;

	[SerializeField]
	public EnemyAI enemyAi;

	[SerializeField]
	public touchControl touchCro;

	[SerializeField]
	public MainGamePanel mainGamePanel;

	private const int MAX_COUNT = 10;

	void Start( ) {
		
		touchCro = GameObject.FindObjectOfType<touchControl>( );

		mainGamePanel = GameObject.FindObjectOfType<MainGamePanel>( );
	}

	void Update( ) {

		enemys = GameObject.FindGameObjectsWithTag( "Enemy" );

		enemyAi = GameObject.FindObjectOfType<EnemyAI>( );

		int m_Count = touchCro.enemyDownCount;

		if ( m_Count >= MAX_COUNT ) {

			m_Count = 0;

			touchCro.enemyDownCount = m_Count;

			RemoveAllEnemy( );

			Debug.Log( "clear" );
		}
	}
		
	void RemoveAllEnemy( ) {
		GameObject[ ] RemoveList = GameObject.FindGameObjectsWithTag( "Enemy" );
		for ( int i = 0; i < RemoveList.Length; i++ ) {
			Destroy( RemoveList[ i ].gameObject );
			Debug.Log( i );
		}
	}

}
