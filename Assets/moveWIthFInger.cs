﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWIthFInger : MonoBehaviour {

	public float smooth = 5.0F;

	public float smoothBack = 5.0F;

	private Quaternion currentRotation;

	public GameObject a;
	public GameObject b;

	void Start(){
		currentRotation = transform.rotation;

		Time.timeScale = 0.7f;
	}
	void Update() {


		Debug.Log(Mathf.Atan2( b.transform.position.x - a.transform.position.x, 
							   b.transform.position.y - a.transform.position.y ) * Mathf.Rad2Deg);
		
		if ( Input.touchCount > 0 ) {
			
			Touch touch = Input.GetTouch( 0 );

			float angleZ = Mathf.Atan2( touch.position.x - transform.position.x, 
										touch.position.y - transform.position.y ) * Mathf.Rad2Deg;

			Quaternion target = Quaternion.Euler( 0, 0, -angleZ );

			transform.rotation = Quaternion.Slerp( transform.rotation, target, Time.deltaTime * smooth );

			if ( touch.phase == TouchPhase.Ended ) {
				Debug.Log( "end" );
				target = Quaternion.Euler( 0, 0, 0 );
				transform.rotation = Quaternion.Slerp( transform.rotation, target, Time.smoothDeltaTime * smoothBack );
			}

		} 
			

	}
}
