using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour, IPointerClickHandler{

	[SerializeField]
	public GameObject mainGameCamera;

	[SerializeField]
	public GameObject targetMark;

	[SerializeField]
	touchControl touchCro;

	[SerializeField]
	public bool isLocked;

	private bool isTurn = false;

	public bool isDead;

	[SerializeField]
	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		
		touchCro = GameObject.Find( "TouchController" ).GetComponent<touchControl>( );

		mainGameCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		rb = gameObject.GetComponent<Rigidbody>( );

		targetMark.SetActive (false);

		isDead = false;

		if ( this.gameObject.tag == "Boss" ) {
			transform.FindChild( "face" ).GetComponent<Renderer>( ).material.SetTextureOffset( "_MainTex", new Vector2( 0f, -0.5f ) );	
		}
	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
			
		if ( !isDead ) {
			transform.LookAt( mainGameCamera.transform.position );
		}

		rb.velocity = Vector3.left * speed;

		if ( isTurn ) {
			rb.velocity = Vector3.right * speed;
		} else if ( !isTurn ) {
			rb.velocity = Vector3.right * -speed;
		}
	}

	public void Dead() {

		isDead = true;

		transform.FindChild( "face" ).GetComponent<Renderer>( ).material.SetTextureOffset( "_MainTex", new Vector2( 0.5f, 0f ) );	

		GetComponent<Animator>( ).StopRecording( );

		//Quaternion target = Quaternion.Euler (-90f, 180f, 0f);
		Quaternion targetRotation = Quaternion.Euler( transform.rotation.x - 90, transform.rotation.y + 180, 0 );
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, 0.1f );

		touchCro.target = null;

		Destroy (gameObject, 2f );

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
			Debug.Log ("Turn");
			isTurn = !isTurn;
		}
	}

	public void OnPointerClick(PointerEventData eventData) 
	{ 
		if ( touchCro.target != null ) {
			if ( touchCro.target != gameObject ) {
				touchCro.target.GetComponent<EnemyAI>( ).MarkKill( );
				touchCro.target.GetComponent<EnemyAI>( ).isLocked = false;
				touchCro.target = null;
			}
		}

		if ( !isLocked ) {
			isLocked = true;
			rb.isKinematic = true;
			touchCro.target = gameObject;
			targetMark.SetActive (true);
		} else {
			isLocked = false;
			rb.isKinematic = false;
			touchCro.target = null;
			targetMark.SetActive (false);
		}
			
	}

	public void MarkKill() {
		targetMark.SetActive (false);
	}
		
}
