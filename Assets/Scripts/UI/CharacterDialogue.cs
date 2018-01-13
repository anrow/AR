using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour {

	public Dialogue dialogue;

	public void TriggerDialogue() {

		FindObjectOfType<DialogueSystem>().StartDialogue(dialogue);

	}
}
