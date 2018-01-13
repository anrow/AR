﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

	public Text nameText;

	public Text dialogueText;

	private Queue<string> sentences;

	private bool characterSelected = false;

	// Use this for initialization
	void Start () {
		
		sentences = new Queue<string>();

	}
	
	public void StartDialogue(Dialogue dialogue) {

		characterSelected = true;

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach ( string sentence in dialogue.sentences ) {

			sentences.Enqueue(sentence);

		}
		
		if(characterSelected) {

			NextSentence();

		}

	}

	public void NextSentence() {

		if(sentences.Count == 0) {

			EndDialogue();

			return;

		}

		string sentence = sentences.Dequeue();

		StopAllCoroutines();

		StartCoroutine(TypeSentence(sentence));

	}

	IEnumerator TypeSentence(string sentence) {

		dialogueText.text = "";

		foreach ( char letter in sentence.ToCharArray() ) {

			dialogueText.text += letter;

			yield return null;

		}

	}

	void EndDialogue() {

		Debug.Log("End of conversation.");

		characterSelected = false;
	}
}
