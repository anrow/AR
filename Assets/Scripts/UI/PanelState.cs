using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelState : MonoBehaviour {
    [SerializeField]
    private GameObject[ ] panel;

    List<string> sceneNames = new List<string>( ) {
        "game",
        "title"
    };
 	// Use this for initialization
	void Start( ) {
        SceneController.GetActiveSceneNames( );
		panel[ 0 ].SetActive( true );
		panel[ 1 ].SetActive( false );
		panel[ 2 ].SetActive( false );
		panel[ 3 ].SetActive( false );
	}
	
	// Update is called once per frame
	void Update( ) {
        PanelStateChanger( );
	}

    public void SetPanelState( int tabNo ) {
      
        switch( tabNo ) {
            case 0:
                Panel.panelName = Panel.PHASE.TITLE;
                break;                   
            case 1:                     
                Panel.panelName = Panel.PHASE.MAIN_MENU;
                break;                   
            case 2:                      
                Panel.panelName = Panel.PHASE.OPTION;
                break;                   
            case 3:                      
                Panel.panelName = Panel.PHASE.CLEARING_HOUSE;
                break;
			case 4:
				Panel.panelName = Panel.PHASE.MAIN_GAME;
				break;
        }
    }

    void PanelStateChanger( ) {
       
        switch( Panel.panelName ) {
            case Panel.PHASE.TITLE:
                panel[ 0 ].SetActive( true );
                panel[ 1 ].SetActive( false );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.PHASE.MAIN_MENU:
                panel[ 0 ].SetActive( false);
                panel[ 1 ].SetActive( true );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.PHASE.OPTION:
                panel[ 0 ].SetActive( false );
                panel[ 1 ].SetActive( true );
                panel[ 2 ].SetActive( true );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.PHASE.CLEARING_HOUSE:
                panel[ 0 ].SetActive( false );
                panel[ 1 ].SetActive( false );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( true );
                break;
			case Panel.PHASE.MAIN_GAME:
                SceneController.MoveScenes( sceneNames );
				break;
        }
    }
}
