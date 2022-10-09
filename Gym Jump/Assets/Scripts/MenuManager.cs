using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject hlMenu;
    public GameObject levels;
    public GameObject options;

    public static int Switch = 0;

    private void Update()
    {
        switch(Switch)
        {
            case 1:
                Play();
                Switch = 0;
                break;
            case 2:
                Options();
                Switch = 0;
                break;
        }
    }

    public void Play()
    {
        hlMenu.SetActive(false);
        levels.SetActive(true);
    }
    public void Options()
    {
        hlMenu.SetActive(false);
        options.SetActive(true);
    }
    public void Menu()
    {
        hlMenu.SetActive(true);
        options.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
