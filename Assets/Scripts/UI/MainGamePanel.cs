﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGamePanel : MonoBehaviour {
	[SerializeField]
	private GameObject[ ] panel;

  	// Use this for initialization
	void Start( ) {
		
	}
	
	// Update is called once per frame
	void Update( ) {
		PanelStateChanger( );
	}
		
	public void SetPanelState( int tabNo ) {

		switch( tabNo ) {
			case 0:
				Panel.gamePanel = Panel.GAME_PHASE.PLAY_METHOD;
				break;                   
			case 1:                     
				Panel.gamePanel = Panel.GAME_PHASE.MAIN_GAME;
				break;                   
			case 2:                      
				Panel.gamePanel = Panel.GAME_PHASE.RESULT;
				break;                   
			case 3:                      
				Panel.gamePanel = Panel.GAME_PHASE.PHOTO;
				break;
		}
	}

	void PanelStateChanger( ) {
		switch ( Panel.gamePanel ) {
			case Panel.GAME_PHASE.PLAY_METHOD:
				panel[ 0 ].SetActive( false );
				panel[ 1 ].SetActive( false );
				panel[ 2 ].SetActive( false );
				panel[ 3 ].SetActive( false );
				break;
			case Panel.GAME_PHASE.MAIN_GAME:
				panel[ 0 ].SetActive( false );
				panel[ 1 ].SetActive( true );
				panel[ 2 ].SetActive( false );
				panel[ 3 ].SetActive( false );
				break;
			case Panel.GAME_PHASE.RESULT:
				panel[ 0 ].SetActive( false );
				panel[ 1 ].SetActive( false );
				panel[ 2 ].SetActive( true );
				panel[ 3 ].SetActive( false );
				break;
			case Panel.GAME_PHASE.PHOTO:
				panel[ 0 ].SetActive( false );
				panel[ 1 ].SetActive( false );
				panel[ 2 ].SetActive( false );
				panel[ 3 ].SetActive( true );
				break;
		}
	}
}
