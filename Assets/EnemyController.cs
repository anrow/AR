using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	[SerializeField]
	private GameObject enemy;

	[SerializeField]
	private Vector3 spwanPoint;



	// Use this for initialization
	void Start () {
		Vector3 position = new Vector3( Random.Range( -spwanPoint.x, spwanPoint.x ), 
										Random.Range( -spwanPoint.y, spwanPoint.y ), 
									    0 );
		Instantiate( enemy, position, Quaternion.identity );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
