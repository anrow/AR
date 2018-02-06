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

    private int m_EnemyDownCount;

    public int EnmeyDownCount {
        get {
            return m_EnemyDownCount;
        }
    }

	void Start( ) {
		
		touchCro = GameObject.FindObjectOfType<touchControl>( );

		mainGamePanel = GameObject.FindObjectOfType<MainGamePanel>( );
	}

	void Update( ) {

		enemys = GameObject.FindGameObjectsWithTag( "Enemy" );

		enemyAi = GameObject.FindObjectOfType<EnemyAI>( );

		m_EnemyDownCount = touchCro.enemyDownCount;

		if ( m_EnemyDownCount >= MAX_COUNT ) {

			m_EnemyDownCount = 0;

			touchCro.enemyDownCount = m_EnemyDownCount;

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
