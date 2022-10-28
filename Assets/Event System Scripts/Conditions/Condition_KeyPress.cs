using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Condition_KeyPress : MonoBehaviour
{
	public enum KeyEventTypes
	{
		JustPressed,
		Released,
		KeptPressed
	}
	[Header("Type of Event")]
	public KeyEventTypes eventType = KeyEventTypes.JustPressed;

	public KeyCode keyToPress;

	public float frequency = 0.5f;

	private float timeLastEventFired;

	public UnityEvent KeyPressEvent;

	private void Start()
	{
		timeLastEventFired = -frequency;
	}

	private void Update()
	{
		switch (eventType)
		{
			case KeyEventTypes.JustPressed:
				if (Input.GetKeyDown(keyToPress))
				{
					KeyPressEvent.Invoke();
				}
				break;
			case KeyEventTypes.Released:
				if (Input.GetKeyUp(keyToPress))
				{
					KeyPressEvent.Invoke();
				}
				break;
			case KeyEventTypes.KeptPressed:
				if (Time.time >= timeLastEventFired + frequency
					&& Input.GetKey(keyToPress))
				{
					KeyPressEvent.Invoke();
					timeLastEventFired = Time.time;
				}
				break;
		}
	}

}
