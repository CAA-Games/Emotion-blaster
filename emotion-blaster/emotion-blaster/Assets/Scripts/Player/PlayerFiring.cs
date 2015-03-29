using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour
{

	public float velocity;

	void Fire ()
	{
		GameObject newBullet = Factory.create.PlayerBullet (transform.position, transform.rotation);

		Vector2 shotDirection = Vector2.right * -1;
		if(gameObject.GetComponent<PlayerInput>().facing == Direction.RIGHT ){
			shotDirection = Vector2.right;
		}

		newBullet.GetComponent<Rigidbody2D> ().AddForce (shotDirection * velocity);
	}
}
