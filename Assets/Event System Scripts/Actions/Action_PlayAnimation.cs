using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_PlayAnimation : MonoBehaviour
{

    public Animator AnimatedObject;

    public string AnimationName;

    void Start()
    {
        
    }

    public void PlayAnimation()
    {
        AnimatedObject.SetTrigger(AnimationName);
    }
}
