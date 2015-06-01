using UnityEngine;
using System.Collections;

public class PlayerControllerRight: MonoBehaviour {
	
	public float speed = 10;
	public string axis = "Vertical2";
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxisRaw ("Vertical2");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;
		
	}
}
