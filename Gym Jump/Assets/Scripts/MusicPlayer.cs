using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    public AudioMixerGroup Output;

    int random = 0;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
        audioSource.volume = 0.2f;
        audioSource.outputAudioMixerGroup =Output;
        //if()

        random = Random.Range(0, clips.Length);
    }

    private AudioClip GetRandomClip()
    {
        random++;
        if (random == 4)
            random = 0;
        return clips[random];
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
