using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Condition_Collision : MonoBehaviour
{

	public enum ColliderEventTypes
	{
		EnterAnyCollision,
		EnterSpecificCollision,
		StayAnyCollision,
		StaySpecificCollision,
		NoCollision
	}

	[Header("Type of Event")]
	public ColliderEventTypes eventType = ColliderEventTypes.EnterAnyCollision;

	[Header("Tag Filter for Specific Collision")]
	public string TagName;

	[Header("Stay Inside Frequency")]
	public float Frequency = 1f;
	private float lastTimeTriggerStayCalled;

	public UnityEvent CollisionEvent;

	void OnCollisionEnter(Collision collision)
	{

		if (eventType == ColliderEventTypes.EnterAnyCollision)
		{
			CollisionEvent.Invoke();
		}

		if (eventType == ColliderEventTypes.EnterSpecificCollision)
		{
			if (collision.collider.CompareTag(TagName))
			{
				CollisionEvent.Invoke();
			}
		}
	}

	void OnCollisionStay(Collision collision)
	{
		if (Time.time >= lastTimeTriggerStayCalled + Frequency)
		{
			if (eventType == ColliderEventTypes.EnterAnyCollision)
			{
				CollisionEvent.Invoke();
				lastTimeTriggerStayCalled = Time.time;
			}

			if (eventType == ColliderEventTypes.EnterSpecificCollision)
			{
				if (collision.collider.CompareTag(TagName))
				{
					CollisionEvent.Invoke();
					lastTimeTriggerStayCalled = Time.time;
				}
			}
		}
	}

	private void OnCollisionExit(Collision collision)
    {
		CollisionEvent.Invoke();
	}
}
