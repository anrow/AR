using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour {

    [SerializeField]
    private Button BtnOptionBack;
        
    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
            case "BtnOptionBack":
                UIManager.Instance.Back( );
                break;
        }
    }
}
