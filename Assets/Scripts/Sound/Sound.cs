using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class Sound {
	
	public string Name;

	public AudioClip Clip;

	[Range( 0, 1f )]
	public float Volume;

	[Range( 0, 3f )]
	public float Pitch;

	[HideInInspector]
	public AudioSource Source;

	public bool isLoop;

}
