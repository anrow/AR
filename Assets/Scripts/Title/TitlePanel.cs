using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour {

    [SerializeField]
    private Button BtnTitleTouch;

	public void OnBtnTitleTouchClick( ) {
        GameManager.Instance.SetMainMenuPanel( );
    }
    private void Start( ) {
        //Invoke( "PlayBgm", 3f );
    }
    private void PlayBgm( ) {
        SoundManager.Instance.PlayBGM( 0 );
    } 
}
