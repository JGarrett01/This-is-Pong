using UnityEngine;
using System.Collections;

public class ResetBall: MonoBehaviour {
	public float speed = 15;
	
	void Start () {

	}
		
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Space))
		{
			transform.position = new Vector2 (0.16f, 4.6f);
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed + Vector2.up * speed;
		}
	}
}
