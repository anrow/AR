using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGamePanel : MonoBehaviour {
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
		
	}

	public void SetPanelState( int tabNo ) {
        
		switch( tabNo ) {
		case 0:
			panel[ 0 ].SetActive( false );
			panel[ 1 ].SetActive( false );
			panel[ 2 ].SetActive( false );
			panel[ 3 ].SetActive( false );
			SceneController.MoveScenes( sceneNames );
			break;
		case 1:
			panel[ 0 ].SetActive( false );
			panel[ 1 ].SetActive( true );
			panel[ 2 ].SetActive( false );
			panel[ 3 ].SetActive( false );
			break;
		case 2:
			panel[ 0 ].SetActive( false );
			panel[ 1 ].SetActive( false );
			panel[ 2 ].SetActive( true );
			panel[ 3 ].SetActive( false );
			break;
		case 3:
			panel[ 0 ].SetActive( false );
			panel[ 1 ].SetActive( false );
			panel[ 2 ].SetActive( false );
			panel[ 3 ].SetActive( true );
			break;
        case 4:
            SceneController.MoveScenes( sceneNames );
            break;

		}
		
	}
}
