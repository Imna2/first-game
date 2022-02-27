using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    
    public AudioSource audio;

    public static MusicManager M;
    void Awake()
    {
        M = this;
    }
    public void PlaySound(AudioClip x)
    {
        audio.PlayOneShot(x);
    }
}
