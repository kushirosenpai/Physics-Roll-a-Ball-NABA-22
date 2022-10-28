using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Particles_On_Off : MonoBehaviour
{
    public ParticleSystem ParticleSystem;

    void Start()
    {
        
    }

    public void ParticlesPlay()
    {
        ParticleSystem.Play(true);
    }

    public void ParticlesPause()
    {
        ParticleSystem.Pause(true);
    }

    public void ParticlesStopEmitting()
    {
        ParticleSystem.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }

    public void ParticlesStop_Clear()
    {
        ParticleSystem.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
}
