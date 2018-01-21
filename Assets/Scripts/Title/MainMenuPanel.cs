using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : MonoBehaviour {
    [SerializeField]
    private Button BtnTop;

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

    private DialogueSystem dialogueSystem;

    void Start( ) {

        dialogueSystem = FindObjectOfType<DialogueSystem>( );

    }
    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
			case "BtnTop":
				SoundManager.Instance.PlaySE( 0 );
				GameManager.Instance.SetTitlePanel( );
                break;

            case "BtnOption":
                SoundManager.Instance.PlaySE( 5 );
                GameManager.Instance.SetOptionPanel( );
                break;

			case "BtnMainGame":
				SoundManager.Instance.PlaySE( 5 );

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
				SoundManager.Instance.PlaySE(1);
				Animator MiraN_Anim = BtnCharacterMiraN.gameObject.GetComponent<Animator>();
				MiraN_Anim.SetTrigger("Pressed");
				//CharacterDialogue.Instance.TriggerDialogue();
				break;
            case "BtnContinue":
                SoundManager.Instance.PlaySE( 1 );
                if( dialogueSystem.nameText.text == "Fuku" ) {

                    Animator anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );

                    anim.SetTrigger( "Pressed" );

                }
                if( dialogueSystem.nameText.text == "Toku" ) {

                    Animator anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );

                    anim.SetTrigger( "Pressed" );

                }
                if( dialogueSystem.nameText.text == "Mira" ) {

                    Animator anim = BtnCharacterMiraN.gameObject.GetComponent<Animator>( );

                    anim.SetTrigger( "Pressed" );

                }
                break;
        }
    }
}
