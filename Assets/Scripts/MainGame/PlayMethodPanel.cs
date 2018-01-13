using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMethodPanel : MonoBehaviour {

	[SerializeField]
	private Button BtnPlayMethodStart;

	public void OnBtnPlayMethodStartClick( ) {
		UIManager.Instance.Enter<MainGamePanel>( false );
	}
}
