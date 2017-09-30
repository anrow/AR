using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchControl : MonoBehaviour {

	public float maxTime;
	public float minSwipeDistance;
	public float swipeDoubleMinDis;
	public float smooth = 5.0F;
	public float smoothBack = 5.0F;
	public GameObject onhUsa;

	float startTime;
	float endTime;

	Vector3 startPos;
	Vector3 endPos;
	float swipeDistance;
	float swipeTime;
	float swipeLength;

	// Use this for initialization
	void Start () {
		
		swipeLength = 0f;
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			//touchTest ();

			Touch touch = Input.GetTouch(0);

			if (touch.position.y <= 300) {

				//Debug.Log (touch.position);

				moveOnhusa ();

				swipeLength = swipeLength + touch.deltaPosition.magnitude;

				if (touch.phase == TouchPhase.Began) {
					startTime = Time.time;
					startPos = touch.position;
				}

				if (touch.phase == TouchPhase.Ended) {
					endTime = Time.time;
					endPos = touch.position;

					swipeDistance = (endPos - startPos).magnitude;
					swipeTime = endTime - startTime;

					swipeDouble ();

					if (swipeTime < maxTime && swipeDistance > minSwipeDistance) {
						//swipe();
					}
				}
			}
		}	
	}

	void swipeDouble(){
		float swipeDis = (endPos - startPos).magnitude;
		//Debug.Log(swipeDis);
		//Debug.Log(swipeLength);
		if (swipeLength > swipeDis + swipeDoubleMinDis)
		{
			Debug.Log("AttackEnemy");
		}
		swipeLength = 0;
	}

	void swipe(){

		Vector2 distance = endPos - startPos;
		if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
		{
			Debug.Log("Horizontal Swipe");

			if (distance.x > 0)
			{
				Debug.Log("Right Swipe");
			}

			if (distance.x < 0)
			{
				Debug.Log("Left Swipe");
			}

		}
		else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
		{
			Debug.Log("Vertical Swipe");

			if (distance.y > 0)
			{
				Debug.Log("Up Swipe");
			}

			if (distance.y < 0)
			{
				Debug.Log("Down Swipe");
			}
		}
	}

	void touchTest(){

		if (Input.GetTouch(0).phase == TouchPhase.Began)
		{
			Debug.Log("Began");
		}

		if (Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Debug.Log("Moved");
		}

		if (Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			Debug.Log("Ended");
		}
	}

	void moveOnhusa(){

		float angleZ = Mathf.Atan2( Input.GetTouch(0).position.x - onhUsa.transform.position.x, 
			Input.GetTouch(0).position.y - onhUsa.transform.position.y ) * Mathf.Rad2Deg;

		Quaternion target = Quaternion.Euler( 0, 0, -angleZ );

		onhUsa.transform.rotation = Quaternion.Slerp( onhUsa.transform.rotation, target, Time.deltaTime * smooth );

		if ( Input.GetTouch(0).phase == TouchPhase.Ended ) {
			
			target = Quaternion.Euler( 0, 0, 0 );
			onhUsa.transform.rotation = Quaternion.Slerp( onhUsa.transform.rotation, target, Time.smoothDeltaTime * smoothBack );

		}

	}
		
}
