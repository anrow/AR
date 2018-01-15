using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour {
    [SerializeField]
    private Button BtnShopBack;

    public void OnBtnClicked( Button _Btn ) {
        switch( _Btn.name ) {
            case "BtnShopBack":
                SoundManager.Instance.PlaySE( 3 );
                UIManager.Instance.Back( );
                break;
        }
    }
}
