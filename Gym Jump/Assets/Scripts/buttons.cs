using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public AudioSource sound;

    public void PlaySound()
    {
        sound.Play();
    }
}
