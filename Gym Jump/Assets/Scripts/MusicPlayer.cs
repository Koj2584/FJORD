using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioClip[] normalClips;
    public AudioSource audioSource;
    public AudioMixerGroup Output;

    int random1 = 0;
    int random2 = 0;

    void Start()
    {
        audioSource.loop = false;
        audioSource.volume = 0.2f;
        audioSource.outputAudioMixerGroup =Output;

        random1 = Random.Range(0, clips.Length);
        random2 = Random.Range(0, normalClips.Length);
    }

    private AudioClip GetRandomClip()
    {
        if (Optons.spravnejOndra)
        {
            random1++;
            if (random1 == clips.Length)
                random1 = 0;
            return clips[random1];
        }
        else
        {
            random2++;
            if (random2 == normalClips.Length)
                random2 = 0;
            return normalClips[random2];
        }
    }
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}
