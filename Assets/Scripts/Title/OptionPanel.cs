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
	
	private int m_BtnBgmCount = 0;
	
	private int m_BtnSeCount = 0;
	
	private bool IsSwitchOn( int _TypeCount ) {
		return _TypeCount % 2 == 0;
	}
	
	void Update( ) {
		
		BtnBgmOn.GetComponent<Image>().sprite = IsSwitchOn( m_BtnBgmCount ) ? ImageYellowOn : ImageRedOn;
		
		BtnBgmOff.GetComponent<Image>().sprite = IsSwitchOn( m_BtnBgmCount ) ? ImageRedOff : ImageYellowOff;
		
		BtnSeOn.GetComponent<Image>().sprite = IsSwitchOn( m_BtnSeCount ) ? ImageYellowOn : ImageRedOn;
		
		BtnSeOff.GetComponent<Image>().sprite = IsSwitchOn( m_BtnSeCount ) ? ImageRedOff : ImageYellowOff;
		
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
