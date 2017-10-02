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

	[SerializeField]
	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		
		touchCro = GameObject.Find( "TouchController" ).GetComponent<touchControl>( );

		mainGameCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		rb = gameObject.GetComponent<Rigidbody>( );

		targetMark.SetActive (false);

	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
			

		transform.LookAt(mainGameCamera.transform.position);

		rb.velocity = Vector3.left * speed;

		if ( isTurn ) {
			rb.velocity = Vector3.right * speed;
		} else if ( !isTurn ) {
			rb.velocity = Vector3.right * -speed;
		}
	}

	public void Dead() {

		transform.FindChild("face").GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", new Vector2(0.5f, 0f));			
		
		GetComponent<Animator> ().Stop ();

		Quaternion target = Quaternion.Euler (-70f, 180f, 0f);

		transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * 2);

		touchCro.targer = null;

		Destroy (gameObject, 2f);

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

	public void OnPointerClick(PointerEventData eventData) 
	{ 
		if ( touchCro.targer != null ) {
			if ( touchCro.targer != gameObject ) {
				touchCro.targer.GetComponent<EnemyAI>( ).MarkKill( );
				touchCro.targer.GetComponent<EnemyAI>( ).isLocked = false;
				touchCro.targer = null;
			}
		}

		if ( !isLocked ) {
			isLocked = true;
			rb.isKinematic = true;
			touchCro.targer = gameObject;
			targetMark.SetActive (true);
		} else {
			isLocked = false;
			rb.isKinematic = false;
			touchCro.targer = null;
			targetMark.SetActive (false);
		}
			
	}

	public void MarkKill() {
		targetMark.SetActive (false);
	}
		
}
