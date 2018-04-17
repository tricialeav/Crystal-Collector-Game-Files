using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCrystal : MonoBehaviour {

//	float score = CalculateScore.score;
	public static float newScore; 


	void OnCollisionEnter(Collision col)
	{ 
		Debug.Log ("Collided with crystal");
		Destroy(this.gameObject); 
		newScore = CalculateScore.score - 1;
		CalculateScore.score = newScore; 
	}
}