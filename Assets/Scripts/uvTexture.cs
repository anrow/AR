using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvTexture : MonoBehaviour {

    public Vector2 face;

    public Renderer rend;

	public touchControl touchCor;

	public GameObject enemy;

	public float smooth;

	bool isDead;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();

		touchCor = FindObjectOfType<touchControl> ();
        
		//face = new Vector2(0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {

		if (touchCor.attackEnemy == true) {

			rend.material.SetTextureOffset ("_MainTex", new Vector2(0.5f, 0f));

			isDead = true;

			if (isDead) {

				enemy.GetComponent<Animator> ().Stop ();

				Quaternion target = Quaternion.Euler (-70f, 180f, 0f);

				enemy.transform.rotation = Quaternion.Slerp (enemy.transform.rotation, target, Time.deltaTime * smooth);

				Destroy (enemy, 2f);
			}
		}

		//touchCor.attackEnemy = false;
	}

}
