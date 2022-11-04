using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_ChangeScale : MonoBehaviour
{
    public GameObject Object;

    public Vector3 NewScale;

    public void ChangeScale()
    {
        Object.GetComponent<Transform>().localScale = NewScale;
    }
}
