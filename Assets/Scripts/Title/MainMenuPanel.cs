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

    private void Start( ) {
    }

    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
            case "BtnTop" :
				SoundManager.Instance.PlaySE( 5 );
                BtnTopCount++;

                BtnShop.gameObject.SetActive( BtnTopCount % 2 != 0 );
                BtnOption.gameObject.SetActive( BtnTopCount % 2 != 0 );
                BtnMainGame.gameObject.SetActive( BtnTopCount % 2 != 0 );
                break;

            case "BtnShop":
                SoundManager.Instance.PlaySE( 5 );
                GameManager.Instance.SetShopPanel( );
                break;

            case "BtnOption":
                SoundManager.Instance.PlaySE( 5 );
                GameManager.Instance.SetOptionPanel( );
                break;

			case "BtnMainGame":
				SoundManager.Instance.PlaySE (5);

				GameManager.Instance.LoadScene ("mainGame");

                break;

            case "BtnCharacterFukuN":
                SoundManager.Instance.PlaySE( 1 );
				Animator FukuN_Anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );
				FukuN_Anim.SetTrigger( "Pressed" );
                break;
            case "BtnCharacterTokuN":
                SoundManager.Instance.PlaySE( 1 );
				Animator TokuN_Anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );
				TokuN_Anim.SetTrigger( "Pressed" );
                break;
			case "BtnCharacterMiraN":
                SoundManager.Instance.PlaySE( 1 );
				Animator MiraN_Anim = BtnCharacterMiraN.gameObject.GetComponent<Animator> ();
				MiraN_Anim.SetTrigger ("Pressed");
				break;
        }
    }
}
