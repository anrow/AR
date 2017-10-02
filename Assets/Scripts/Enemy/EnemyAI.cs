using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAI : MonoBehaviour {

	[SerializeField]
	public touchControl touch_control;

	[SerializeField]
	public GameObject mainGameCamera;

	[SerializeField]
	public GameObject targetMark;

	[SerializeField]
	public bool isLocked;

	[SerializeField]
	public float speed;

	private bool isTurn = false;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		touch_control = GameObject.FindObjectOfType<touchControl> ();

		mainGameCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		rb = gameObject.GetComponent<Rigidbody>( );

		isLocked = false;

	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
		if (isLocked) {
			targetMark.SetActive (true);
			rb.isKinematic = true;
		} else {
			targetMark.SetActive (false);
			rb.isKinematic = false;
		}
			
		transform.LookAt(mainGameCamera.transform.position);
		rb.velocity = Vector3.left * speed;

		if ( isTurn ) {
			rb.velocity = Vector3.right * speed;
		} else if ( !isTurn ) {
			rb.velocity = Vector3.right * -speed;
		}

		if (touch_control.hit.collider == this.GetComponent<SphereCollider> ()) {
			isLocked = true;
			Debug.Log ("Be Hit!!");
		}

	}
		
	void OnTriggerEnter( Collider other ) {
		if ( other.tag == "CameraBox" ) {
			isTurn = !isTurn;
		}
		
	}
	void OnTriggerStay( Collider other ) {
		
	}
	void OnTriggerExit( Collider other ) {
		if ( other.tag == "EnemySpawner" ) {
			isTurn = !isTurn;
		}
	}
}
