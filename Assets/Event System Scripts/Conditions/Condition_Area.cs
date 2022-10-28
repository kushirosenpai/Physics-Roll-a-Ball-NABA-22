using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Condition_Area : MonoBehaviour
{
    public enum ColliderEventTypes
    {
        Enter,
        Exit,
        StayInside
    }

    [Header("Type of Event")]
    public ColliderEventTypes eventType = ColliderEventTypes.Enter;

    [Header("Object Filter")]
    public string TagName;

    [Header("Stay Inside Frequency")]
    public float Frequency = 1f;
    private float lastTimeTriggerStayCalled;

    public UnityEvent AreaEvent;


    // Start is called before the first frame update
    void Start()
    {
        lastTimeTriggerStayCalled = -Frequency;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (eventType == ColliderEventTypes.Enter)
        {
            if (collider.CompareTag(TagName))
            {
                AreaEvent.Invoke();
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (eventType == ColliderEventTypes.Exit)
        {
            if (collider.CompareTag(TagName))
            {
                AreaEvent.Invoke();
            }
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        if (eventType == ColliderEventTypes.StayInside
            && Time.time >= lastTimeTriggerStayCalled + Frequency)
        {
            if (collider.CompareTag(TagName))
            {
                AreaEvent.Invoke();
                lastTimeTriggerStayCalled = Time.time;
            }
        }
    }

}
