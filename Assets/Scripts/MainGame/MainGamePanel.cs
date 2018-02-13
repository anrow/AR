using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGamePanel : MonoBehaviour {

	[SerializeField]
	private Button BtnPause;

    [SerializeField]
    private GameObject mGo_EnemyDownCountPanel;

    [SerializeField]
    private GameObject mGo_CoinCountPanel;

	public void OnBtnPauseClick( ) {
        SoundManager.Instance.PlaySE( 5 );
		GameManager.Instance.SetGamePause( true );
		UIManager.Instance.Enter<PausePanel>( true );
	}
    private void Start( ) {
        
    }
    private void Update( ) {

        CountNumberView theEnemyCountDownView  = mGo_EnemyDownCountPanel.GetComponentInChildren<CountNumberView>( );
        CountNumberView theCoinCountDownView  = mGo_CoinCountPanel.GetComponentInChildren<CountNumberView>( );
        
        theEnemyCountDownView.Number = GameManager.Instance.GetEnemyDownCount( );
        theCoinCountDownView.Number = GameManager.Instance.GetCoinCount( );
    }
}
