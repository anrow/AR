using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class battleField : MonoBehaviour, IPointerEnterHandler {

	public enemyCro enemyCroScr;

	public GameObject battlePlane;

	public GameObject[] enemyBattle;

	public GameObject testButton;
	// Use this for initialization
	void Start () {
		enemyCroScr = FindObjectOfType<enemyCro> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyCroScr.startBattle) {
			
			enemyCroScr.startBattle = false;
			battlePlane.SetActive (true);

			/*for (int i = 0; i < enemyBattle.Length; i++) {
				
				Instantiate (enemyBattle[i], randomVector(), Quaternion.identity);

			}*/

			Instantiate (enemyBattle[0], new Vector3(0, 1, 5), Quaternion.identity);
			Instantiate (enemyBattle[1], new Vector3(0, -1, 5), Quaternion.identity);
			Instantiate (enemyBattle[2], new Vector3(1, 1, 5), Quaternion.identity);
		}
			
		isEnemyExist ();
	}

	Vector3 randomVector(){

		Vector3 randomPos = new Vector3 (Random.Range (-1, 1),
			                    		 Random.Range (-1, 1),
			                    		 5);
		
		return randomPos;
	}

	public void OnPointerEnter (PointerEventData eventData)
	{
		Debug.Log ( ">>>" );
	}

	void isEnemyExist(){
		if(GameObject.Find("enemy(Clone)") != null) {
			Debug.Log("get Enemy");
		} else {
			Debug.Log("no Enemy");
			testButton.SetActive (true);
		}
			
	}

}

