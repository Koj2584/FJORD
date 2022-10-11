using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown dropdown;

    Resolution[] resolution;

    private void Start()
    {
        resolution = Screen.resolutions;

        dropdown.ClearOptions();

        List<string> list = new List<string>();

        int resolutionIndex = 0;
        foreach(Resolution r in resolution)
        {
            string option = r.width + " x " + r.height;
            list.Add(option);

            if (r.width == Screen.currentResolution.width&&r.height==Screen.currentResolution.height)
            {
                resolutionIndex = list.Count-1;
            }
        }

        dropdown.AddOptions(list);
        dropdown.value = resolutionIndex;
        dropdown.RefreshShownValue();
    }

    public void SetResolution(int index)
    {
        Screen.SetResolution(resolution[index].width, resolution[index].height,Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void SetFullscreen(bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
    }
    public void PravejOndra(bool ondra)
    {
        Optons.spravnejOndra = ondra;
    }
}
