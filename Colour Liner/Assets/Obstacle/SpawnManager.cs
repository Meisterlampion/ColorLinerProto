﻿using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public int maxPlatforms = 20;
	public GameObject obstacle_blue;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -5;
	public float verticalMax = 5f;

	private Vector2 originPosition;




	// Use this for initialization
	void Start () {
	
		originPosition = transform.position;
		Spawn ();

	}
	void Spawn ()
	{
		for (int i = 0; i < maxPlatforms; i++) 
		{
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate (obstacle_blue, randomPosition, Quaternion.identity);
			originPosition = randomPosition;

		}
	}

}
