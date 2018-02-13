using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	
	[SerializeField]
	public GameObject[ ] enemys;

	[SerializeField]
	public EnemyAI enemyAi;

    [SerializeField]
    private EnemySpawner theEnemySpawner;

	[SerializeField]
	public touchControl touchCro;

	[SerializeField]
	public MainGamePanel mainGamePanel;

	private const int MAX_COUNT = 10;

    private int m_EnemyDownCount;

    private bool isClear = false;

    public bool IsClear( ) {
        return isClear;
    }
    public int EnmeyDownCount {
        get {
            return m_EnemyDownCount;
        }
    }

	void Start( ) {
		
        isClear = false;

		touchCro = GameObject.FindObjectOfType<touchControl>( );

		mainGamePanel = GameObject.FindObjectOfType<MainGamePanel>( );

        theEnemySpawner = GameObject.FindObjectOfType<EnemySpawner>( );
	}

	void Update( ) {

		enemys = GameObject.FindGameObjectsWithTag( "Enemy" );

		enemyAi = GameObject.FindObjectOfType<EnemyAI>( );
        
		m_EnemyDownCount = touchCro.enemyDownCount;

		if ( m_EnemyDownCount >= MAX_COUNT ) {

			//m_EnemyDownCount = 0;

			//touchCro.enemyDownCount = m_EnemyDownCount;
          
			RemoveAllEnemy( );

		}

        if( theEnemySpawner.IsBossShow ) {

            GameObject theBoss = GameObject.FindGameObjectWithTag( "Boss" );
            
            if( theBoss.GetComponent<EnemyAI>( ).isDead ) {
                isClear = true;
                Invoke( "SetClear", 1f );
                theEnemySpawner.IsBossShow = false;
                
            }
        }
        
	}
		
	void RemoveAllEnemy( ) {
		GameObject[ ] RemoveList = GameObject.FindGameObjectsWithTag( "Enemy" );
		for ( int i = 0; i < RemoveList.Length; i++ ) {
			Destroy( RemoveList[ i ].gameObject );
		}
	}

    void SetClear( ) {
        GameManager.Instance.SetClearPanel( );
    }
}
