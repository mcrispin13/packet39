using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioSource : MonoBehaviour
{

    private AudioSource theAudioSource;

    public AudioClip backgroundConstructionSite;

    
    void Awake()
    {
        theAudioSource = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        PlayBackground ();
    }

    public void PlayBackground ()
    {
        theAudioSource.loop = true;
        theAudioSource.volume = 0.02f;
        theAudioSource.clip = backgroundConstructionSite;
        theAudioSource.Play();
    }

}
