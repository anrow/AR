﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webCamScript : MonoBehaviour {
	
	[SerializeField]
	public GameObject webCameraPlane;

	// Use this for initialization
	void Start () {

		if ( Application.isMobilePlatform ) {
			GameObject cameraParent = new GameObject( "camParent" );

			cameraParent.transform.position = this.transform.position;

			this.transform.parent = webCameraPlane.transform;

			cameraParent.transform.Rotate( Vector3.left, 90 );

	

		}

		Input.gyro.enabled = true;

		WebCamTexture webCamTexture = new WebCamTexture( );

		webCameraPlane.GetComponent<MeshRenderer>( ).material.mainTexture = webCamTexture;

		webCamTexture.Play( );


	}
	
	// Update is called once per frame
	void Update () {

		Quaternion cameraRotation = new Quaternion( Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w );

		this.transform.localRotation = cameraRotation;
	}
}
