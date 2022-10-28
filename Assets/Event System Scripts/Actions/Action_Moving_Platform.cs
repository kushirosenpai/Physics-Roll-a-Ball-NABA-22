using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Moving_Platform : MonoBehaviour
{

    public Transform Platform;
    public Transform Player;
    public float speed;

    public void SyncPlatformMovement()
    {
        Player.transform.position = Vector3.Lerp(Player.transform.position, Platform.position, speed * Time.deltaTime);
    }

    public void BecomeParent()
    {
        Player.transform.parent = Platform.transform;
    }

    public void VoidParent()
    {
        Player.transform.parent = null;
    }
}
