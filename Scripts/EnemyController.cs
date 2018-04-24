using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public Transform PlayerTransform;
	public float walkingDistance = 20.0f;
	public float smoothTime = 0.75f;
	private Vector3 smoothVelocity = Vector3.one;



	void Update()
	{

		transform.LookAt(PlayerTransform);
		float distance = Vector3.Distance(transform.position, PlayerTransform.position);
		if(distance < walkingDistance && PlayerBehavior.PlayerHealth > 0 && CalculateScore.score > 0)
		{
			transform.position = Vector3.SmoothDamp(transform.position, PlayerTransform.position, ref smoothVelocity, smoothTime);
		}
	}
}
