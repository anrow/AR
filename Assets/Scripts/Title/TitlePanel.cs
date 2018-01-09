using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour {

    [SerializeField]
    private Button BtnTitleTouch;

    private void Start( ) {
        BtnTitleTouch.onClick.AddListener( ( ) => OnBtnTitleTouchClick( ) );
    }

    private void OnBtnTitleTouchClick( ) {
        GameManager.Instance.SetMainMenuPanel( );
    }
}
