using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehavior : MonoBehaviour {

	public Mesh[] mMeshes;

	private MeshFilter mFilter;

	void Awake()
	{
		mFilter = GetComponent<MeshFilter>();
	}

	void Update()
	{
		if(Input.GetButtonDown("Fire2"))
			mFilter.mesh = mMeshes[Random.Range(0, mMeshes.Length)];
	}
}
