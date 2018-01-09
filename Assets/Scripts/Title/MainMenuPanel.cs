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
    private Button BtnCharacterFirst;
    
    [SerializeField]
    private Button BtnCharacterSecond;

    [SerializeField]
    private Button BtnCharacterThird;

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

            case "BtnCharacterFirst":
                Animator F_Animator = BtnCharacterFirst.gameObject.GetComponent<Animator>( );
                F_Animator.SetTrigger( "Pressed" );
                break;
            case "BtnCharacterSecond":
                Animator S_Animator = BtnCharacterSecond.gameObject.GetComponent<Animator>( );
                S_Animator.SetTrigger( "Pressed" );
                break;
        }
    }
}
