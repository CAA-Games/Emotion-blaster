using UnityEngine;
using System.Collections;

public class BasicEnemyAI : MonoBehaviour
{
	public float acceleration;
	public float maxSpeed;
	public Direction facing = Direction.LEFT;


	void Update ()
	{
		if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < maxSpeed) {
			Accelerate();
		}
	}

	void Accelerate() {
		Vector2 direction = Vector2.right;
		if(facing == Direction.LEFT) {
			direction *= -1;
		}
		gameObject.GetComponent<Rigidbody2D> ().AddForce (direction * acceleration);
	}

	void TurnRight() {
		facing = Direction.RIGHT;
	}

	void TurnLeft() {
		facing = Direction.LEFT;
	}
}
