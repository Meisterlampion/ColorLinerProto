using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//Movement Variabeln
	private float movex;
	private float movey;
	public float moveSpeed;


	
	// Update is called once per frame
	void FixedUpdate () {
	
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertikal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * moveSpeed, movey * moveSpeed);
	}
}
