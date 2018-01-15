using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour {

	[SerializeField]
	private Button BtnBackToGame;

	[SerializeField]
	private Button BtnBackToTitle;

	public void OnBtnClicked( Button _Btn ) {
		switch( _Btn.name ) {
			case "BtnBackToGame":
                SoundManager.Instance.PlaySE( 3 );
				GameManager.Instance.SetGamePause( false );
				UIManager.Instance.Back( );
				break;
			case "BtnBackToTitle":
                SoundManager.Instance.PlaySE( 0 );
				GameManager.Instance.SetGamePause( false );
				GameManager.Instance.LoadScene( "title" );
				break;
		}
	}
}
