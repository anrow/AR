using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamera : MonoBehaviour {

	private Gyroscope gyro;

	private GameObject cameraContainer;

	private Quaternion rot;

	private WebCamTexture cam;

	private bool isArReady = false;

	[SerializeField]
	private RawImage background;

	[SerializeField]
	private AspectRatioFitter fit;

	private void Start( ) {
		
		if ( !SystemInfo.supportsGyroscope ) {
			Debug.Log( "this device deos not supoort Gyroscope" );
			return;
		}

		for ( int i = 0; i < WebCamTexture.devices.Length; i++ ) {
			
			if ( !WebCamTexture.devices[ i ].isFrontFacing ) {
				cam = new WebCamTexture( WebCamTexture.devices[ i ].name, Screen.width, Screen.height );
				break;
			}
		}

		if ( cam == null ) {
			Debug.Log( "deos not have back camera" );
			return;
		}

		cameraContainer = new GameObject( "CameraContainer" );

		cameraContainer.transform.position = transform.position;

		transform.SetParent( cameraContainer.transform );

		gyro = Input.gyro;

		gyro.enabled = true;

		cam.Play( );
		background.texture = cam;
		cameraContainer.transform.rotation = Quaternion.Euler( 90f, 0, 0 );
		rot = new Quaternion( 0, 0, 1, 0 );

		isArReady = true;
	}

	private void Update( ) {

		if ( isArReady ) {

			//Update Camera
			float ratio = (float)cam.width / (float)cam.height;

			fit.aspectRatio = ratio;

			float scaleY = cam.videoVerticallyMirrored ? -1.0f : 1.0f;

			background.rectTransform.localScale = new Vector3( 1f, scaleY, 1.0f );

			int orient = -cam.videoRotationAngle;

			background.rectTransform.localEulerAngles = new Vector3( 0, 0, orient );

			transform.localRotation = gyro.attitude * rot;
		}
	}
}
