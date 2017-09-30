using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvTexture : MonoBehaviour {

    public Vector2 face;

    public Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();

        face = new Vector2(0f, -0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        rend.material.SetTextureOffset("_MainTex", face);
	}
}
