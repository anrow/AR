using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAI : MonoBehaviour, IPointerClickHandler {

	[SerializeField]
	public GameObject mainGameCamera;

	[SerializeField]
	public GameObject targetMark;

	[SerializeField]
	public bool isLocked = false;

	private bool isTurn = false;

	[SerializeField]
	public float speed = 10f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>( );

	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
		
		transform.rotation = mainGameCamera.transform.rotation;

		rb.velocity = Vector3.left * speed;

		if ( isTurn ) {
			rb.velocity = Vector3.right * speed;
		} else if ( !isTurn ) {
			rb.velocity = Vector3.right * -speed;
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

	public void OnPointerClick (PointerEventData eventData) 
	{
		if( eventData.clickCount > 0 ){

			isLocked = true;

		}
	}
}
