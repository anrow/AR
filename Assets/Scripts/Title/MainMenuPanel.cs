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

	[SerializeField]
	private Button BtnOverMira;

	[SerializeField]
	private Button BtnOverFuku;

	[SerializeField]
	private Button BtnOverToku;

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
				BtnOverFuku.gameObject.SetActive(true);
				BtnOverMira.gameObject.SetActive(false);
				BtnOverToku.gameObject.SetActive(false);
                SoundManager.Instance.PlaySE( 1 );
				Animator FukuN_Anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );
				FukuN_Anim.SetTrigger( "Pressed" );
                break;
            case "BtnCharacterTokuN":
				BtnOverToku.gameObject.SetActive(true);
				BtnOverMira.gameObject.SetActive(false);
				BtnOverFuku.gameObject.SetActive(false);
                SoundManager.Instance.PlaySE( 1 );
				Animator TokuN_Anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );
				TokuN_Anim.SetTrigger( "Pressed" );
                break;
			case "BtnCharacterMiraN":
				BtnOverMira.gameObject.SetActive(true);
				BtnOverFuku.gameObject.SetActive(false);
				BtnOverToku.gameObject.SetActive(false);
				SoundManager.Instance.PlaySE(1);
				Animator MiraN_Anim = BtnCharacterMiraN.gameObject.GetComponent<Animator>();
				MiraN_Anim.SetTrigger("Pressed");
				break;

            case "BtnContinue":
                SoundManager.Instance.PlaySE( 1 );
                if( dialogueSystem.nameText.text == "ふくロック" ) {

                    Animator anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );

                    anim.SetTrigger( "Pressed" );
					if( dialogueSystem.sentences.Count <= 1 ) {

						BtnOverFuku.gameObject.SetActive(false);

					}
                }
                if( dialogueSystem.nameText.text == "徳山君" ) {

                    Animator anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );


                    anim.SetTrigger( "Pressed" );
					if( dialogueSystem.sentences.Count <= 1 ) {

						BtnOverToku.gameObject.SetActive(false);

					}
                }
                if( dialogueSystem.nameText.text == "みらいちゃん" ) {

                    Animator anim = BtnCharacterMiraN.gameObject.GetComponent<Animator>( );

                    anim.SetTrigger( "Pressed" );
					if( dialogueSystem.sentences.Count <= 1 ) {

						BtnOverMira.gameObject.SetActive(false);

					}
                }
                break;

			case "BtnOverMira":
				if( dialogueSystem.nameText.text == "みらいちゃん" ) {

					Animator anim = BtnCharacterMiraN.gameObject.GetComponent<Animator>( );

					anim.SetTrigger( "Pressed" );
					
				if( dialogueSystem.sentences.Count <= 1 ) {

					BtnOverMira.gameObject.SetActive(false);
				}

				}
				break;

			case "BtnOverFuku":
				if( dialogueSystem.nameText.text == "ふくロック" ) {

					Animator anim = BtnCharacterFukuN.gameObject.GetComponent<Animator>( );

					anim.SetTrigger( "Pressed" );

					if( dialogueSystem.sentences.Count <= 1 ) {

						BtnOverFuku.gameObject.SetActive(false);
					}

				}
				break;

			case "BtnOverToku":
				if( dialogueSystem.nameText.text == "徳山君" ) {

					Animator anim = BtnCharacterTokuN.gameObject.GetComponent<Animator>( );

					anim.SetTrigger( "Pressed" );

					if( dialogueSystem.sentences.Count <= 1 ) {

						BtnOverToku.gameObject.SetActive(false);
					}

				}
				break;
        }
    }
}
