using UnityEngine;
using System.Collections;

public class Action_DontDestroyOnLoad : MonoBehaviour
{
    
    void Awake()
    {
        DontDestroyOnLoad(GetComponent<AudioSource>());
    }

    void Start()
    {

    }
}