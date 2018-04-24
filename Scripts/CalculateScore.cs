using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CalculateScore : MonoBehaviour {

	public GameObject crystalPrefab; 
	public GameObject[] crystals;
	public static float score; 
	public float delay = 2.0f;

	IEnumerator MyMethod() {
		yield return new WaitForSeconds (delay);
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		PlayerBehavior.PlayerHealth = 100.0f;
		}

	void Start()
	{
		crystals = GameObject.FindGameObjectsWithTag("Pick Up");
		score = crystals.Length;
		GetComponent<TextMesh>().text="Crystals Remaining: " + score;
	}

	void Update() {
		if (score == crystals.Length && PlayerBehavior.PlayerHealth > 0) {
			GetComponent<TextMesh> ().text = "Crystals Remaining: " + score; 
		} else if (GetCrystal.newScore > 0 && PlayerBehavior.PlayerHealth > 0) {
			GetComponent<TextMesh> ().text = "Crystals Remaining: " + GetCrystal.newScore; 
		} else if (PlayerBehavior.PlayerHealth > 0) {
			GetComponent<TextMesh> ().text = "Quest Complete!"; 
			StartCoroutine (MyMethod ());
		}
	}
}
		