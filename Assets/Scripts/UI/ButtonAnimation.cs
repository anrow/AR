using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {

	public void OnCharacterButtonClick( bool isPressed ) {

		Animator anim = this.gameObject.GetComponent<Animator> ();

		anim.SetBool ("isPressed", isPressed );


	}
}
