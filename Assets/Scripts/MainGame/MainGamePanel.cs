using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGamePanel : MonoBehaviour {

	[SerializeField]
	private Button BtnPause;

	public void OnBtnPauseClick( ) {
        SoundManager.Instance.PlaySE( 5 );
		GameManager.Instance.SetGamePause( true );
		UIManager.Instance.Enter<PausePanel>( true );
	}
}
