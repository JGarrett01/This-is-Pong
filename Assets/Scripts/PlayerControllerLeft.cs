using UnityEngine;
using System.Collections;

public class PlayerControllerLeft: MonoBehaviour {

	public float speed = 10;
	public string axis = "Vertical";


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxisRaw ("Vertical");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;

	}
}
