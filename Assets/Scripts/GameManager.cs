using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private UIManager m_UIManager;

    private static GameManager instance;

    public static GameManager Instance {
        get {
            if( instance == null ) {
                instance = GameObject.FindObjectOfType<GameManager>( );
            }
            return instance;
        }
    }

    public void LoadScene( string sceneName ) {
        SceneManager.LoadScene( sceneName );
    }

    private void Awake( ) {
        if( m_UIManager == null ) {
            m_UIManager = GameObject.FindObjectOfType<UIManager>( );
        }
    }

    private void Start( ) {
        m_UIManager.Enter<LogoPanel>( );
        Invoke( "SetTitlePanel", 4f );
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
}
