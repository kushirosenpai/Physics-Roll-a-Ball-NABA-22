using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Audio_On_Off : MonoBehaviour
{
    public AudioSource AudioSource;

    void Start()
    {
        
    }

    public void PlayAudio()
    {
        StartCoroutine(PlayAudioCont());
    }   

    IEnumerator PlayAudioCont()
    {
        AudioSource.Play();
        yield return new WaitForSeconds(AudioSource.GetComponent<AudioSource>().clip.length);
    }

    public void StopAudio()
    {
        AudioSource.Stop();
    }
}
