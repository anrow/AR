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
    private List<GameObject> m_PanelList = new List<GameObject>( );

    [SerializeField]
    private List<GameObject> m_CurrentPanelList;

    [SerializeField]
    public GameObject mGo_CurrentPanel = null;

    private void Start( ) {
        m_CurrentPanelList = new List<GameObject>( );

		switch (SceneManager.GetActiveScene ().name) {
		case "title":
			
			break;
		}
    }

    public T Enter<T>( ) where T : MonoBehaviour {

        foreach( var _Panel in m_PanelList ) {

            T thePanel = _Panel.GetComponent<T>( );

            if( thePanel != null ) {

                if( mGo_CurrentPanel != null ) {
                    mGo_CurrentPanel.SetActive( false );
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
}
