using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
	public float delay = 1.0f;
	public Animator anim; 
	public static bool attacking = false; 


	IEnumerator MyMethod() {
		yield return new WaitForSeconds (delay);
		attacking = false; 
		yield break;
	}

	void Start()
	{
		anim.Play ("Idle");
	}

	void Update() {
		if (attacking == false) {
			anim.Play ("Idle");
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" && PlayerBehavior.PlayerHealth > 0 && CalculateScore.score > 0) {
			attacking = true; 
			anim.Play ("Attack");
			StartCoroutine (MyMethod ());
		}
	}
}