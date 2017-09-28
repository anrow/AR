using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAI : MonoBehaviour, IPointerClickHandler {

	[SerializeField]
	private GameObject mainCamera;

	[SerializeField]
	public TouchController touchController;

	[SerializeField]
	public GameObject targetMark;

	[SerializeField]
	public bool isLocked = false;

	private bool isTurn = false;

	[SerializeField]
	public float speed = 2f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>( );
		touchController = GameObject.FindObjectOfType<TouchController>( );
	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
		if ( isLocked ) {
			targetMark.SetActive( true );
			speed = 0;

		}
		transform.rotation = mainCamera.transform.rotation;

		rb.velocity = Vector3.left * speed;

		if ( isTurn ) {
			rb.velocity = Vector3.right * speed;
		} else if ( !isTurn ) {
			rb.velocity = Vector3.right * -speed;
		}
	}
		
	void OnTriggerEnter( Collider other ) {
		
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
