using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour {

    [SerializeField]
    private Button BtnOptionBack;
    
	[SerializeField]
	private Button BtnBgmOn;
	
	[SerializeField]
	private Button BtnBgmOff;
	
	[SerializeField]
	private Button BtnSeOn;
	
	[SerializeField]
	private Button BtnSeOff;
	
	[SerializeField]
	private Sprite ImageYellowOn;
	
	[SerializeField]
	private Sprite ImageYellowOff;
	
	[SerializeField]
	private Sprite ImageRedOn;
	
	[SerializeField]
	private Sprite ImageRedOff;
	
	private static int m_BtnBgmCount = 1;
	
	private static int m_BtnSeCount = 1;
	
	private bool IsSwitchOn( int _TypeCount ) {
		return _TypeCount % 2 == 0;
	}
	
	void Update( ) {
		
		BtnBgmOn.GetComponent<Image>().sprite = IsSwitchOn( m_BtnBgmCount ) ? ImageRedOn : ImageYellowOn;
		
		BtnBgmOff.GetComponent<Image>().sprite = IsSwitchOn( m_BtnBgmCount ) ? ImageYellowOff : ImageRedOff;
		
		BtnSeOn.GetComponent<Image>().sprite = IsSwitchOn( m_BtnSeCount ) ? ImageRedOn : ImageYellowOn;
		
		BtnSeOff.GetComponent<Image>().sprite = IsSwitchOn( m_BtnSeCount ) ? ImageYellowOff : ImageRedOff;
		
        SoundManager.Instance.StopBGM( IsSwitchOn( m_BtnBgmCount ) );
        
        SoundManager.Instance.StopSE( IsSwitchOn( m_BtnSeCount ) );
	}
	
	private void CheckBtnSprite( int _Count, Sprite _SelfSprite, Sprite _TargetSprite ) {
		_SelfSprite = _Count % 2 == 0 ? _TargetSprite : _SelfSprite;
	}
	
    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
            case "BtnOptionBack":
                SoundManager.Instance.PlaySE( 3 );
                UIManager.Instance.Back( );
                break;
			case "BtnBgmOn":
				m_BtnBgmCount++;
				SoundManager.Instance.PlaySE(5);
				break;
			case "BtnBgmOff":
				m_BtnBgmCount++;
				SoundManager.Instance.PlaySE(5);
				break;
			case "BtnSeOn":
				m_BtnSeCount++;
				SoundManager.Instance.PlaySE(5);
				break;
			case "BtnSeOff":
				m_BtnSeCount++;
				SoundManager.Instance.PlaySE(5);
				break;
        }
    }
}
