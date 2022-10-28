using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public string CheckpointTag;

    public Transform CurrentCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(CheckpointTag))
        {
            CurrentCheckpoint = other.transform;
        }
    }

    public void Respawn()
    {
        gameObject.transform.position = CurrentCheckpoint.transform.position;
    }

}
