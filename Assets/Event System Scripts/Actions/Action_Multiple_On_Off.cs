using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Multiple_On_Off : MonoBehaviour
{
    [Header("Are The Objects On or Off?")]
    public bool On_Off;

    [Header("Object List")]
    public GameObject[] Objects;

    void Start()
    {
        
    }

    public void Multiple_OnOff()
    {
        foreach (GameObject obj in Objects)
            obj.SetActive(On_Off);
    }
}
