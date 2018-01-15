using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    private static UIManager instance;

    public static UIManager Instance {
        get {
            if( instance == null ) {
                instance = GameObject.FindObjectOfType<UIManager>( );
            }
            return instance;
        }
    }

    [SerializeField]
	private List<GameObject> m_PanelList;

    [SerializeField]
    private List<GameObject> m_CurrentPanelList;

    [SerializeField]
    private GameObject mGo_CurrentPanel = null;

    public GameObject GetCurrentPanel{
        get { return mGo_CurrentPanel; }
        set { mGo_CurrentPanel = value; }
    }

	public void TitleInit( ) {
		m_PanelList = new List<GameObject> ();
		m_CurrentPanelList = new List<GameObject>( );

		GameObject Go_LogoPanel = GameObject.FindObjectOfType<LogoPanel> ().gameObject;
		GameObject Go_ShopPanel = GameObject.FindObjectOfType<ShopPanel> ().gameObject;
		GameObject Go_MainMenuPanel = GameObject.FindObjectOfType<MainMenuPanel> ().gameObject;
		GameObject Go_OptionPanel = GameObject.FindObjectOfType<OptionPanel> ().gameObject;
		GameObject Go_TitlePanel = GameObject.FindObjectOfType<TitlePanel> ().gameObject;

		m_PanelList.Add( Go_LogoPanel );
		m_PanelList.Add( Go_ShopPanel );
		m_PanelList.Add( Go_MainMenuPanel );
		m_PanelList.Add( Go_OptionPanel );
		m_PanelList.Add( Go_TitlePanel );

		foreach( GameObject _Panel in m_PanelList ) {
			_Panel.SetActive( false );
		}

		if( GameManager.IsCreated( ) ) {
			
			GameManager.Instance.SetLogoPanel( );

			Invoke( "SetTitlePanel", 3f );

		} else {
			
			GameManager.Instance.SetTitlePanel( );
		}
	}

	public void MainGameInit( ) {
		m_PanelList = new List<GameObject> ();
		m_CurrentPanelList = new List<GameObject>( );

		GameObject Go_PlayMethodPanel = GameObject.FindObjectOfType<PlayMethodPanel>( ).gameObject;
		GameObject Go_MainGamePanel = GameObject.FindObjectOfType<MainGamePanel>( ).gameObject;
		GameObject Go_PausePanel = GameObject.FindObjectOfType<PausePanel>( ).gameObject;
		GameObject Go_ResultPanel = GameObject.FindObjectOfType<ResultPanel>( ).gameObject;
		GameObject Go_ClearPanel = GameObject.FindObjectOfType<ClearPanel>( ).gameObject;

		m_PanelList.Add( Go_PlayMethodPanel );
		m_PanelList.Add( Go_MainGamePanel );
		m_PanelList.Add( Go_PausePanel );
		m_PanelList.Add( Go_ResultPanel );
		m_PanelList.Add( Go_ClearPanel );
		

		foreach( GameObject _Panel in m_PanelList ) {
			_Panel.SetActive( false );
		}

		Enter<PlayMethodPanel>( false );
	}

    public T Enter<T>( bool isBeforePanelActive ) where T : MonoBehaviour {

        foreach( var _Panel in m_PanelList ) {

            T thePanel = _Panel.GetComponent<T>( );

            if( thePanel != null ) {

                if( mGo_CurrentPanel != null ) {
                    mGo_CurrentPanel.SetActive( isBeforePanelActive );
                }

                thePanel.gameObject.SetActive( true );

                mGo_CurrentPanel = thePanel.gameObject;

                m_CurrentPanelList.Add( mGo_CurrentPanel );
            }
        }
        return null;
    }

    public void Back( ) {
         
        for( int i = m_CurrentPanelList.Count - 1; i >= 0; --i ) {
           
            if( i > 0 ) {

                if( i - 1 >= 0 ) {

                    m_CurrentPanelList[ i - 1 ].SetActive( true );

                    m_CurrentPanelList[ i ].SetActive( false );

                    RemoveList( mGo_CurrentPanel );

                    mGo_CurrentPanel = m_CurrentPanelList[ i - 1 ];

                    return;

                }

            }

        }
    }

    private void RemoveList( GameObject _Go ) {

        for( int i = 0; i < m_CurrentPanelList.Count; ++i ) {

            if( m_CurrentPanelList[ i ] == _Go ) {
                m_CurrentPanelList.RemoveAt( i );
                return;
            }

        }
    }

	private void SetTitlePanel( ) {
		GameManager.Instance.SetTitlePanel( );
	}
}
