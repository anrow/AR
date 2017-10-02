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
	public bool isLocked;

	private bool isTurn = false;

	[SerializeField]
	public float speed;

	private Rigidbody rb;

	Quaternion angle;
	// Use this for initialization
	void Start () {

		mainGameCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		rb = gameObject.GetComponent<Rigidbody>( );

		angle = Quaternion.Euler (0, 180, 0);

		targetMark.SetActive (false);

	}

	void FixedUpdated( ) {
		
	}

	// Update is called once per frame
	void Update () {
		if (isLocked) {
			targetMark.SetActive (true);


		} else {
			targetMark.SetActive (false);
		}
			
		//transform.rotation = mainGameCamera.transform.rotation;
		//transform.Rotate( mainGameCamera.transform.rotation.x, mainGameCamera.transform.rotation.y + 180, mainGameCamera.transform.rotation.z );
		//transform.rotation = Quaternion.Euler( mainGameCamera.transform.rotation.x, mainGameCamera.transform.rotation.y + 180, mainGameCamera.transform.rotation.z );
		transform.LookAt(mainGameCamera.transform.position);
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

		isLocked = !isLocked;
	}
		
}
