using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanel : MonoBehaviour {
    [SerializeField]
    private GameObject mGo_EnemyDownCountPanel;

    [SerializeField]
    private GameObject mGo_CoinCountPanel;

    [SerializeField]
    private Button BtnReturnToTitle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CountNumberView theEnemyCountDownView  = mGo_EnemyDownCountPanel.GetComponentInChildren<CountNumberView>( );
        CountNumberView theCoinCountDownView  = mGo_CoinCountPanel.GetComponentInChildren<CountNumberView>( );
        
        theEnemyCountDownView.Number = GameManager.Instance.GetEnemyDownCount( );
        theCoinCountDownView.Number = GameManager.Instance.GetCoinCount( );
	}

    public void OnBtnClicked( ) {
        GameManager.Instance.LoadScene( "title" );
        GameManager.Instance.SetLogoPanel( );
    }
}
