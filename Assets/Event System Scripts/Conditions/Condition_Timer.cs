using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Condition_Timer : MonoBehaviour
{
    public enum TimerEventTypes
    {
        Timer,
        Countdown
    }

    [Header("Type of Event")]
    public TimerEventTypes eventType = TimerEventTypes.Timer;

    [Header("Is Timer Active?")]
    public bool TimerActive;

    [Header("Timer Value")]
    public float _time;

    public TMP_Text TimerText;

    private float minutes, seconds;

    [Header("Add Timer Events at Time Points")]
    //public TimerEventClass[] TimerEvents;

    public List<TimerEventClass> TimerEvents;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(TimerActive)
        {
            if (eventType == TimerEventTypes.Timer)
            {
                _time += Time.deltaTime;
            }

            if (eventType == TimerEventTypes.Countdown)
            {
                _time -= Time.deltaTime;
            }

            minutes = Mathf.FloorToInt(_time / 60);
            seconds = Mathf.FloorToInt(_time % 60);

            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        TimerEvents_Play();
    }

    public void TimerEvents_Play()
    {
        foreach(TimerEventClass TimerEvent in TimerEvents)
        {
            if (_time >= TimerEvent.TargetTime)
            {
                TimerEvent.TimerEvent.Invoke();
            }
        }
    }

    public void StopTimer()
    {
        TimerActive = false;
    }
}

[Serializable]
public class TimerEventClass
{
    public float TargetTime;
    public UnityEvent TimerEvent;
}


