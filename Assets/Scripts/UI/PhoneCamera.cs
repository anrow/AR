using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PhoneCamera : MonoBehaviour {
		
	private bool camAvailable;

	private WebCamTexture backCam;

	private Texture defaultBackGround;

	public RawImage background;

	public AspectRatioFitter fit;

	public Button takePhotoBtn;



	// Use this for initialization
	void Start () {

		takePhotoBtn = GameObject.Find ("TakePhotoButton").GetComponent<Button> ();

		Debug.Log (takePhotoBtn);

		defaultBackGround = background.texture;

		WebCamDevice[] devices = WebCamTexture.devices;

		if ( devices.Length == 0 ) {
			Debug.Log( "no camera" );

			camAvailable = false;

			return;
		}

		for ( int i = 0; i < devices.Length; i++ ) {
			if ( !devices[ i ].isFrontFacing ) {
				backCam = new WebCamTexture( devices[ i ].name, Screen.width, Screen.height );
			}
		}

		if ( backCam == null ) {
			Debug.Log( "Unable to find back camera" );
			return;
		}

		backCam.Play( );
		background.texture = backCam;
	}
	
	// Update is called once per frame
	void Update () {
		if ( !camAvailable ) {
			return;
		}

		float ratio = ( float )backCam.width / ( float )backCam.height;
		fit.aspectRatio = ratio;

		float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f;

		background.rectTransform.localScale = new Vector3( 1f, scaleY, 1f );

		int orient = -backCam.videoRotationAngle;

		background.rectTransform.localEulerAngles = new Vector3( 0, 0, orient );



	}

	private void TakePhoto( ) {

		Texture2D photo = new Texture2D (backCam.width, backCam.height);

		photo.SetPixels (backCam.GetPixels ());

		photo.Apply ();

		//Encode to a PNG
		byte[] bytes = photo.EncodeToPNG();
		//Write out the PNG. Of course you have to substitute your_path for something sensible
		File.WriteAllBytes( "Assets/" + "photo.png", bytes);

	}
}
