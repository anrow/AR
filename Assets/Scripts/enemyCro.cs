using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemyCro : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler {

	public bool startBattle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter (PointerEventData eventData)
	{
		Debug.Log ( ">>>" );
	}

	public void OnPointerClick(PointerEventData eventData){
		Debug.Log("!!!!");
		startBattle = true;
		Destroy (gameObject);
	}
}
