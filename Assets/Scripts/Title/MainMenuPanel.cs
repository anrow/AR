using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : MonoBehaviour {
    [SerializeField]
    private Button BtnTop;

    [SerializeField]
    private Button BtnShop;

    [SerializeField]
    private Button BtnOption;

    [SerializeField]
    private Button BtnMainGame;

    [SerializeField]
    private Button BtnCharacterFukuN;
    
    [SerializeField]
    private Button BtnCharacterTokuN;

    [SerializeField]
    private Button BtnCharacterMiraN;

    int BtnTopCount = 1;

    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
            case "BtnTop" :

                BtnTopCount++;

                BtnShop.gameObject.SetActive( BtnTopCount % 2 != 0 );
                BtnOption.gameObject.SetActive( BtnTopCount % 2 != 0 );
                BtnMainGame.gameObject.SetActive( BtnTopCount % 2 != 0 );
                break;

            case "BtnShop":
                GameManager.Instance.SetShopPanel( );
                break;

            case "BtnOption":
                GameManager.Instance.SetOptionPanel( );
                break;

            case "BtnMainGame":
                GameManager.Instance.LoadScene( "mainGame" );
                break;

            case "BtnCharacterFukuN":
				Animator FukuN_Anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );
				FukuN_Anim.SetTrigger( "Pressed" );
                break;
            case "BtnCharacterTokuN":
				Animator TokuN_Anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );
				TokuN_Anim.SetTrigger( "Pressed" );
                break;
			case "BtnCharacterMiraN":
				Animator MiraN_Anim = BtnCharacterMiraN.gameObject.GetComponent<Animator> ();
				MiraN_Anim.SetTrigger ("Pressed");
				break;
        }
    }
}
