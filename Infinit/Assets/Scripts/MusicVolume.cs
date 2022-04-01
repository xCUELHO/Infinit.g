using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    private AudioSource audioSrc;
    private float Volume = 1f;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = Volume;
    }

    public void SetVolume(float vol){
        Volume = vol;
    }
}
