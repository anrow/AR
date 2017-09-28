using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

	private Material _material;

	void Start( ) {

		_material = gameObject.GetComponent<Renderer>( ).material;

		Texture texture = _material.mainTexture;
	}
}
