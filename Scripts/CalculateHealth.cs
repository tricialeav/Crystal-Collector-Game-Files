using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerBehavior.PlayerHealth > 0) {
			GetComponent<TextMesh> ().text = "Health: " + PlayerBehavior.PlayerHealth;
		} else {
			GetComponent<TextMesh> ().text = "Health: 0";
		}
	}
}