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
        set {
            m_CurrentGameState = value;
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
                    Debug.Log( "false" );
                    
                    Destroy( mGo_GameManagers[ i ].gameObject );
                    isCreated = false;
                } else {
                Debug.Log( "true" );
                isCreated = true;
                
                DontDestroyOnLoad( this.gameObject );
                }
            }
        }
    }

	private void Start( ) {
        
		NowSceneName = SceneManager.GetActiveScene( ).name;

		switch( SceneManager.GetActiveScene( ).name ) {
			case "title":
				m_UIManager.TitleInit( );
				break;
			case "mainGame":
				m_UIManager.MainGameInit( );
				break;
		}
    
	}
	private void Update( ) {
		if( NowSceneName != SceneManager.GetActiveScene( ).name ) {
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

	public void SetTitlePanel( ) {
        m_UIManager.Enter<TitlePanel>( false );
        m_CurrentGameState = GameState.Title;
    }
    public void SetMainMenuPanel( ) {
        m_UIManager.Enter<MainMenuPanel>( false );
        m_CurrentGameState = GameState.MainMenu;
    }
    public void SetOptionPanel( ) {
        m_UIManager.Enter<OptionPanel>( true );
    }
    public void SetShopPanel( ) {
        m_UIManager.Enter<ShopPanel>( false );
    }

	public void LoadScene( string sceneName ) {
        SceneManager.LoadScene( sceneName );
    }
}
