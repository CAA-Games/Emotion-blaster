using UnityEngine;
using System.Collections;

public class SendMessageOnTrigger : MonoBehaviour
{

	public string triggerTargetTag;
	public string messageOnEnter;
	public string messageOnExit;

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (messageOnEnter.Length > 0 && (coll.tag.Equals (triggerTargetTag) || triggerTargetTag.Length == 0)) {
			gameObject.SendMessageUpwards (messageOnEnter);
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (messageOnExit.Length > 0 && (coll.tag.Equals (triggerTargetTag) || triggerTargetTag.Length == 0)) {
			gameObject.SendMessageUpwards (messageOnExit);
		}
	}
}
