using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
	private Transform player;
	public Vector3 offset;
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		offset = transform.position - player.position;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = player.position + offset;
	}
}


