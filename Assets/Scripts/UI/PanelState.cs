using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelState : MonoBehaviour {
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
				Panel.titlePanel = Panel.TITLE_PHASE.TITLE;
                break;                   
            case 1:                     
                Panel.titlePanel = Panel.TITLE_PHASE.MAIN_MENU;
                break;                   
            case 2:                      
                Panel.titlePanel = Panel.TITLE_PHASE.OPTION;
                break;                   
            case 3:                      
                Panel.titlePanel = Panel.TITLE_PHASE.CLEARING_HOUSE;
                break;
        }
    }

    void PanelStateChanger( ) {
       
		switch( Panel.titlePanel ) {
            case Panel.TITLE_PHASE.TITLE:
                panel[ 0 ].SetActive( true );
                panel[ 1 ].SetActive( false );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.TITLE_PHASE.MAIN_MENU:
                panel[ 0 ].SetActive( false);
                panel[ 1 ].SetActive( true );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.TITLE_PHASE.OPTION:
                panel[ 0 ].SetActive( false );
                panel[ 1 ].SetActive( true );
                panel[ 2 ].SetActive( true );
                panel[ 3 ].SetActive( false );
                break;
            case Panel.TITLE_PHASE.CLEARING_HOUSE:
                panel[ 0 ].SetActive( false );
                panel[ 1 ].SetActive( false );
                panel[ 2 ].SetActive( false );
                panel[ 3 ].SetActive( true );
                break;
        }
    }
}
