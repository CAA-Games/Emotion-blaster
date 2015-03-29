using UnityEngine;
using System.Collections;

public class SendMessageOnTrigger : MonoBehaviour
{

	public string triggerTargetTag;
	public string messageOnEnter;
	public string messageOnExit;

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag.Equals (triggerTargetTag)) {
			gameObject.SendMessageUpwards (messageOnEnter);
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.tag.Equals (triggerTargetTag)) {
			gameObject.SendMessageUpwards (messageOnExit);
		}
	}
}
