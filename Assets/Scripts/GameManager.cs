using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private UIManager m_UIManager;

    [SerializeField]
    private SoundManager m_SoundManager;

	private string NowSceneName;

    private static GameManager instance;

    public static GameManager Instance {
        get {
            if( instance == null ) {
                instance = GameObject.FindObjectOfType<GameManager>( );
            }
            return instance;
        }
    }

	private static bool isCreated = false; 

	public static bool IsCreated( ) {
		return isCreated;
	}

    public enum GameState {
        Null,
        Logo,
        Title,
        MainMenu,
        MainGame,
        Clear,
        Result
    }

    public GameState CurrentGameState {
        get {
            return m_CurrentGameState;
        }
    }

    private GameState m_CurrentGameState = GameState.Null;

    private void Awake( ) {

        if( m_UIManager == null ) {
            m_UIManager = GameObject.FindObjectOfType<UIManager>( );
        }
        if( m_SoundManager == null ) {
            m_SoundManager = GameObject.FindObjectOfType<SoundManager>( );
        }

        GameObject[ ] mGo_GameManagers = GameObject.FindGameObjectsWithTag( "GameManager" );

        foreach( GameObject _Go in mGo_GameManagers ) {
			
            for( int i = 0; i < mGo_GameManagers.Length; i++ ) {
				
                if( i >= 1 ) {
					
                    Destroy( mGo_GameManagers[ i ].gameObject );
                    isCreated = false;

				} else {
					
                isCreated = true;
                DontDestroyOnLoad( this.gameObject );

                }
            }
        }
    }

	private void Start( ) {
        
		NowSceneName = SceneManager.GetActiveScene( ).name;

		if (NowSceneName == "title") {
			m_CurrentGameState = GameState.Logo;
		} else if (NowSceneName == "mainGame") {
			m_CurrentGameState = GameState.MainGame;
		}

		switch( m_CurrentGameState ) {
		case GameState.Logo:
				m_UIManager.TitleInit( );
			break;
		case GameState.Title:
			
			break;
		case GameState.MainMenu:
			
			break;
		case GameState.MainGame:
				m_UIManager.MainGameInit( );
			break;
		}
    
	}
	private void Update( ) {
		if( NowSceneName != SceneManager.GetActiveScene().name ) {
			Start( );
        }
	}

	public void SetGamePause( bool isPause ) { 
		if( isPause ) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}

	} 

	public void SetLogoPanel( ) {
		m_CurrentGameState = GameState.Logo;
		m_UIManager.Enter<LogoPanel>( false );
	}

	public void SetTitlePanel( ) {
		
		if( m_CurrentGameState == GameState.MainMenu ) {
			
			m_UIManager.Back();
			
		} else {
			
			m_UIManager.Enter<TitlePanel>(false);
		}
		
		m_CurrentGameState = GameState.Title;
		
		SoundManager.Instance.PlayBGM( 0 );
    }
	public void SetMainMenuPanel( ) {
		m_CurrentGameState = GameState.MainMenu;
        m_UIManager.Enter<MainMenuPanel>( false );
		SoundManager.Instance.PlayBGM (1);
    }
    public void SetOptionPanel( ) {
        m_UIManager.Enter<OptionPanel>( true );
    }
	public void SetPlayMethodPanel( ) {
		m_UIManager.Enter<PlayMethodPanel>( false );
	}

	public void LoadScene( string sceneName ) {
        SceneManager.LoadScene( sceneName );
    }
}
