using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
	public float delay = 3.0f;
//	public Rigidbody rb;
	public Animator anim; 
	public static bool attacking = false; 
//	public Vector3 position; 
//	public GameObject enemy; 
 
//	public Transform PlayerTransform; 

	IEnumerator MyMethod() {
//		Debug.Log ("Wait 3 seconds");
		yield return new WaitForSeconds (delay);
		attacking = false; 
		yield break;
	}

	void Start()
	{
//		rb = GetComponent<Rigidbody>();
		anim.Play ("Idle");
	}

	void Update() {
		if (attacking == false) {
			anim.Play ("Idle");
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" && PlayerBehavior.PlayerHealth > 0) {
			attacking = true; 
			anim.Play ("Attack");
			StartCoroutine (MyMethod ());
		}
	}
}