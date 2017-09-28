using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimate : MonoBehaviour {
	[SerializeField]
	private Animator anim;

	void Start( ) {
		anim = gameObject.GetComponentInChildren<Animator>( );
	}

	void Update( ) {
		if ( Input.GetKeyDown( KeyCode.Space ) ) {
			anim.Play( "Idle" );
		}
	}
}
