using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource EffectSource, MoveSource;

    
    [SerializeField] private AudioClip fireSound;
    
    public AudioClip FireSound { get => fireSound; set => fireSound = value; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RunSound()
    {
        MoveSource.Play();
    }
    public void StopRunSound()
    {
        MoveSource.Stop();
    }
    public void PlayEffectSound(AudioClip clipToPlay)
    {
        //if (EffectSource.isPlaying) return;

        EffectSource.PlayOneShot(clipToPlay);
    }
}
