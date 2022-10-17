using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Hlasky : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audioSource;
    public AudioMixerGroup Output;
    public float cas;
    public int max = 200;

    int random = 0;

    void Start()
    {
        if(Optons.smrt)
        {
            audioSource.clip = clips[0];
            audioSource.Play();
            Optons.smrt = true;
        }
        audioSource.loop = false;
        audioSource.volume = 1f;
        audioSource.outputAudioMixerGroup = Output;
        cas = Random.Range(10, max);
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(1, clips.Length)];
    }
    void Update()
    {
        cas -= Time.deltaTime;
        if (!audioSource.isPlaying && cas <= 0)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
            cas = Random.Range(10, max);
        }
    }
}
