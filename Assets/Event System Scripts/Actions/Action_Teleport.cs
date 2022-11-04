using UnityEngine;
using System.Collections;

public class Action_Teleport : MonoBehaviour {

public GameObject gameObject;

public Transform target;

public void Teleport(){
    gameObject.transform.position = target.position;
}

}