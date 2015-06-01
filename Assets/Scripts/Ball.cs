using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float speed = 15;
	public float speedMax = 16;
	public float speedMin = 14;
	

	// Use this for initialization
	void Start () {
	//initial velocity
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}

	void FixedUpdate () {
		if (rigidbody2D.velocity.magnitude > speedMax)
		{	
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * speedMax;
		}

		if (rigidbody2D.velocity.magnitude < speedMin)
		{	
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * speedMin;
		}

	}
		
}