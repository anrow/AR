using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour {
	
	private static CharacterDialogue instance;
	
	public static CharacterDialogue Instance {
		get {
			
			if ( instance == null ) {
				instance = FindObjectOfType<CharacterDialogue>();
			}
			
			return instance;
		}
	}
	
	public Dialogue dialogue;

	public void TriggerDialogue() {

		FindObjectOfType<DialogueSystem>().StartDialogue(dialogue);

	}
}
