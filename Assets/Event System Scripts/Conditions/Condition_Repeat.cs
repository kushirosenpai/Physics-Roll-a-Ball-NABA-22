using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Condition_Repeat : MonoBehaviour
{
	public float initialDelay = 0f;
	public float frequency = 1f;

	private float timeLastEventFired;

	public UnityEvent RepeatEvent;


	private void Start()
	{
		timeLastEventFired = initialDelay - frequency;
	}


	private void Update()
	{
		if (Time.time >= timeLastEventFired + frequency)
		{
			RepeatEvent.Invoke();
			timeLastEventFired = Time.time;
		}
	}
}
