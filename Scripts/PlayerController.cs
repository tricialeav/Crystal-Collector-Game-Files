using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	void Update()
	{

		// DeltaTime makes the game frame rate independent I want to move this object x amount per second
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 8.0f;


		// Affects a non-rigidbody's position and rotation
		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}

