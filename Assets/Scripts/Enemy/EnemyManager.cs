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

	public int count;

	private const int MAX_COUNT = 5;

	void Start( ) {
		
		touchCro = GameObject.FindObjectOfType<touchControl>( );

		mainGamePanel = GameObject.FindObjectOfType<MainGamePanel>( );
	}

	void Update( ) {

		enemys = GameObject.FindGameObjectsWithTag( "Enemy" );

		enemyAi = GameObject.FindObjectOfType<EnemyAI>( );

		count = touchCro.enemyDownCount;

		if ( count > MAX_COUNT ) {

			count = 0;

			touchCro.enemyDownCount = count;

			Invoke( "SetClear", 2f );

			Debug.Log( "clear" );
		}
	}
	void SetClear( ) {
		mainGamePanel.SetPanelState( 5 );
	}
}
