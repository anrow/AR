using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Panel {

    [SerializeField]
    public enum PHASE {
        TITLE,
        MAIN_MENU,
        OPTION,
        CLEARING_HOUSE,
		MAIN_GAME
    }

    [SerializeField]
	public enum STATE {
		ON,
		OFF
	}

    public static PHASE panelName = PHASE.TITLE;

	public static STATE panelState = STATE.OFF;

}
