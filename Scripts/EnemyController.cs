using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	//The target player
	public Transform PlayerTransform;
	//At what distance will the enemy walk towards the player?
	public float walkingDistance = 20.0f;
	//In what time will the enemy complete the journey between its position and the players position
	public float smoothTime = 2.0f;
	//Vector3 used to store the velocity of the enemy
	private Vector3 smoothVelocity = Vector3.one;
	//Call every frame


	void Update()
	{
		//Look at the player
		transform.LookAt(PlayerTransform);
		//Calculate distance between player
		float distance = Vector3.Distance(transform.position, PlayerTransform.position);
		//If the distance is smaller than the walkingDistance
		if(distance < walkingDistance && EnemyBehavior.attacking == false && PlayerBehavior.PlayerHealth > 0 && CalculateScore.score > 0)
		{
			//Move the enemy towards the player with smoothdamp
			transform.position = Vector3.SmoothDamp(transform.position, PlayerTransform.position, ref smoothVelocity, smoothTime);
		}
	}
}
