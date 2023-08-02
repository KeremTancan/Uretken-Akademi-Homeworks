using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Singleton ile ate� etme, �lme , kazanma ve tank seslerini kontrol etti�im, ba�ka scriptten �a��rd���m script

    public static SoundManager Instance;

    [SerializeField] private AudioSource EffectSource, RunSource;
    [SerializeField] private AudioClip fireSound;
    [SerializeField] private AudioClip dieSound;
    [SerializeField] private AudioClip winSound;
    public AudioClip FireSound { get => fireSound; set => fireSound = value; }
    public AudioClip DieSound { get => dieSound; set => dieSound = value; }
    public AudioClip WinSound { get => winSound; set => winSound = value; }

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
    private bool isPlaying;
    public void RunSound()
    {
        RunSource.Play();
    }

    public void SetVolume(float volume)
    {
        var _volume = .2f + ((.6f - .2f) * volume);
        RunSource.volume = _volume;
    }

    public void StopRunSound()
    {
        RunSource.Stop();
    }
    public void PlayEffectSound(AudioClip clipToPlay)
    {
        //if (EffectSource.isPlaying) return; // art arda ate� edilme sesi duyulmak istemezse bu sat�r yorumdan kald�r�l�r

        EffectSource.PlayOneShot(clipToPlay);
    }
}
