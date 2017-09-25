using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceCamera : MonoBehaviour {

    private bool isCamAvailable;

    private WebCamTexture backCam;

    private Texture defaultBackground;

    [SerializeField]
	public GameObject backgroundPanel;

    /*private void Start( ) {
        WebCamDevice[ ] devices = WebCamTexture.devices;

		defaultBackground = backgroundPanel.GetComponent<MeshRenderer>( ).material.mainTexture;

        if( devices.Length == 0 ) {

            Debug.Log( "No Camera" );

            isCamAvailable = false;

            return;
        }

        for( int i = 0; i < devices.Length; i++ ) {
            if( !devices[ i ].isFrontFacing ) {
				backCam = new WebCamTexture( devices[ i ].name, defaultBackground.width, defaultBackground.height );
            }
        }

        if( backCam == null ) {
            Debug.Log( "Unable to find backCamera" );
            return;
        }

        backCam.Play( );
		defaultBackground = backCam;

        isCamAvailable = true;
    }

    private void Update( ) {
		if ( !isCamAvailable ) {
			return;
		}
	}*/

	void Start( ) {
		WebCamDevice[ ] devices = WebCamTexture.devices;
		WebCamTexture webCamTexture = new WebCamTexture( );
		webCamTexture.deviceName = devices[ 0 ].name;
		this.GetComponent<MeshRenderer>( ).material.mainTexture = webCamTexture; 
	}

	void Update( ) {
	}
}
