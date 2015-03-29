using UnityEngine;
using System.Collections;

public class CheatCodez : MonoBehaviour
{

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F1)) {
			Factory.create.Enemy (new Vector2 (Random.Range (-10, 10), Random.Range (-10, 10)), Quaternion.identity);
		}

		if (Input.GetKeyDown (KeyCode.F2)) {
			Factory.create.Spawner (new Vector2 (Random.Range (-10, 10), Random.Range (-10, 10)), Quaternion.identity);
		}
	}
}
