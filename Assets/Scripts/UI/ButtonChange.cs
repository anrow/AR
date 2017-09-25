using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour {
	[SerializeField]
	private Button mainGameButton;

	[SerializeField]
	private Sprite[ ] toChangeImage;

	void Start( ) {
		mainGameButton = gameObject.GetComponent<Button>( );
		//mainGameButton.image.sprite = toChangeImage[ 0 ];
	}
}
