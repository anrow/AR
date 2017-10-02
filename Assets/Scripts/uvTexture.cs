using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvTexture : MonoBehaviour {

    public Renderer rend;

	public touchControl touchCor;

	// Use this for initialization
	void Start () {
		
        rend = GetComponent<Renderer>();

		touchCor = FindObjectOfType<touchControl> ();
        
	}
		


}