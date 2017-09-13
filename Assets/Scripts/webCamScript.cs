using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webCamScript : MonoBehaviour {

	public GameObject webCameraPlane;

	public Vector3 offset;

	public int width;

	public int height;

	public int FPS;

	private bool isCamAvailable = false;

	private WebCamTexture backCam;

	private Texture defaultBackground;

	public RawImage background;

	public AspectRatioFitter fit;

	// Use this for initialization
	/*void Start () {

		if (Application.isMobilePlatform) {
			GameObject cameraParent = new GameObject ("camParent");
			cameraParent.transform.position = this.transform.position;
			this.transform.parent = cameraParent.transform;
			cameraParent.transform.Rotate (Vector3.right, 180);
		}

		Input.gyro.enabled = true;

		WebCamTexture webCameraTexture = new WebCamTexture();
		webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
		webCameraTexture.Play();

	}
		
	// Update is called once per frame
	void Update () {

		Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, Input.gyro.attitude.w);
		this.transform.localRotation = cameraRotation;
	}*/

	void Start( ) {
		
		WebCamDevice[ ] devices = WebCamTexture.devices;
	
		if (devices.Length == 0) {
			Debug.Log ("No Camera");
			isCamAvailable = false;
			return;
		}

		for (int i = 0; i < devices.Length; i++) {
			if (!devices [i].isFrontFacing) {
				backCam = new WebCamTexture (devices [i].name, Screen.width, Screen.height);
			}
		}

		if (backCam == null) {
			Debug.Log ("Unable to find back camera");
			return;
		}

		backCam.Play ();
		background.texture = backCam;
		isCamAvailable = true;
	}

	void Update( ) {
		if (!isCamAvailable) {
			return;
		}

		float ratio = (float)backCam.width / (float)backCam.height;
		fit.aspectRatio = ratio;

		float scaleY = backCam.videoVerticallyMirrored ? -2f : 2f;
		background.rectTransform.localScale = new Vector3 (2f, scaleY, 1f);

		int orient = -backCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3 (0, 0, orient);
	}
}
