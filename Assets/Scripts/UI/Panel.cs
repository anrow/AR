using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Panel {

    [SerializeField]
    public enum TITLE_PHASE {
        TITLE,
        MAIN_MENU,
        OPTION,
        CLEARING_HOUSE,

    }

	[SerializeField]
	public enum GAME_PHASE {
		PLAY_METHOD,
		MAIN_GAME,
		RESULT,
		PHOTO
	}
		
    public static TITLE_PHASE titlePanel = TITLE_PHASE.TITLE;

	public static GAME_PHASE gamePanel = GAME_PHASE.PLAY_METHOD;

}
