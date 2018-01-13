using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private UIManager m_UIManager;

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

    private void Awake( ) {
        if( m_UIManager == null ) {
            m_UIManager = GameObject.FindObjectOfType<UIManager>( );
        }
		if( !isCreated ) {

			DontDestroyOnLoad( this.gameObject );

			isCreated = true;
		} else {
			Destroy( this.gameObject );
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
        m_UIManager.Enter<TitlePanel>( );
    }
    public void SetMainMenuPanel( ) {
        m_UIManager.Enter<MainMenuPanel>( );
    }
    public void SetOptionPanel( ) {
        m_UIManager.Enter<OptionPanel>( );
    }
    public void SetShopPanel( ) {
        m_UIManager.Enter<ShopPanel>( );
    }

	public void LoadScene( string sceneName ) {
        SceneManager.LoadScene( sceneName );
    }
}
