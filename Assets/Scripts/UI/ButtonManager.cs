using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
	[SerializeField]
	private GameObject[ ] buttons;

	[SerializeField]
	public enum BUTTON_NAME {
		TITLE_TOUCH,
		CLEARING_HOUSE,
		OPTION,
		MAIN_GAME,
		OPTION_BACK,
		STAFF,
		BGM_ON,
		BGM_OFF,
		SE_ON,
		SE_OFF,
		CLEARING_HOUSE_BACK
	};

	public BUTTON_NAME buttonName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnButtonClick( ) { 
		
	}
}
