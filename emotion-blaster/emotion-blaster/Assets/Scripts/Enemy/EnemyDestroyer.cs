using UnityEngine;
using System.Collections;

public class EnemyDestroyer : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.tag.Equals ("Enemy")) {
			coll.gameObject.SetActive(false);
		}
	}
}
