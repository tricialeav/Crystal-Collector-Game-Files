using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
	public Animator anim; 
	public GameObject text;
//	public Collision collision = new Collision();
	public static float PlayerHealth = 100.0f; 
	public bool isBeingAttacked = false;
	public float delay = 2.0f;


	IEnumerator MyMethod() {
		yield return new WaitForSeconds (delay);
		if (PlayerHealth > 0) {
			isBeingAttacked = false; 
			yield break;
		} else {
			anim.Play ("Death"); 
			yield return new WaitForSeconds (delay);
			text.GetComponent<TextMesh>().text = "Game Over";
		}
	}

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Enemy") {
			foreach (ContactPoint contact in collision.contacts) {
				isBeingAttacked = true; 
				PlayerHealth -= 5.0f; 
				anim.Play ("Hurt");
				StartCoroutine (MyMethod ());
			}
		} 
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHealth > 0) {
			if (Input.GetKey ("w") || Input.GetKey ("d") || Input.GetKey ("s") || Input.GetKey ("a") ||
			    Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.RightArrow) ||
			    Input.GetKey (KeyCode.LeftArrow)) {
				anim.Play ("Fly");
			} else if (!isBeingAttacked) { 
				anim.Play ("Wait");
			}
	}
	}
}
