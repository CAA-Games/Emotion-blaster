using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{

	public float acceleration;
	public float jumpForce;
	public bool grounded;
	public Direction facing;
	
	void Update ()
	{
		Movement ();
		Firing ();
	}
	
	void Movement ()
	{	
		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0);
		if (input.x > 0) {
			facing = Direction.RIGHT;
		} else if(input.x < 0) {
			facing = Direction.LEFT;
		}
		gameObject.GetComponent<Rigidbody2D> ().AddForce (input * acceleration);

		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
	}

	void Jump() {
		if (grounded) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpForce);
		}
	}

	void Firing ()
	{
		if (Input.GetMouseButtonDown (0)) {
			InvokeRepeating ("InvokeFiring", 0, 0.16f);
		}
		if (Input.GetMouseButtonUp (0)) {
			CancelInvoke ();
		}
	}
	
	void InvokeFiring ()
	{
		gameObject.SendMessage ("Fire");
	}

	public void OnGround ()
	{
		grounded = true;		
	}

	public void InAir ()
	{
		grounded = false;
	}
}
