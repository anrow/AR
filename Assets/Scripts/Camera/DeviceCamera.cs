﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceCamera : MonoBehaviour {

    private bool isCamAvailable;

    private WebCamTexture backCam;

    private Texture defaultBackground;

    [SerializeField]
    public RawImage background;

    [SerializeField]
    public AspectRatioFitter fit;

    private void Start( ) {
        defaultBackground = background.texture;
        WebCamDevice[ ] devices = WebCamTexture.devices;

        if( devices.Length == 0 ) {

            Debug.Log( "No Camera" );

            isCamAvailable = false;

            return;
        }

        for( int i = 0; i < devices.Length; i++ ) {
            if( !devices[ i ].isFrontFacing ) {
                backCam = new WebCamTexture( devices[ i ].name, Screen.width, Screen.height );
            }
        }

        if( backCam == null ) {
            Debug.Log( "Unable to find backCamera" );
            return;
        }

        backCam.Play( );
        background.texture = backCam;

        isCamAvailable = true;
    }

    private void Update( ) {
        if( !isCamAvailable ) {
            return;
        }

        float ratio = (float)backCam.width / (float)backCam.height;
        fit.aspectRatio = ratio;

        float scaleY = backCam.videoVerticallyMirrored ? -3f : 3f;
        background.rectTransform.localScale = new Vector3( 2f, scaleY, 1f );

        int orient = -backCam.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3( 0, 0, orient );
    }
}
