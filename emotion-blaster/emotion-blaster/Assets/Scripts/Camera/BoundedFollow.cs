using UnityEngine;
using System.Collections;

public class BoundedFollow : MonoBehaviour
{
	public GameObject player;
	public float boundedness;
	public float z = -10;

	void Update ()
	{
		Vector3 position = player.transform.position / boundedness;
		position.z = z;
		transform.position = position;
	}
}
