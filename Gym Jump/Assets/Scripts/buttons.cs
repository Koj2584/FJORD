using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public AudioSource sound;

    public void PlaySound()
    {
        sound.Play();
    }

    public void PlayLvl()
    {
        try
        {
            SceneManager.LoadScene(int.Parse(gameObject.name));
        }
        catch
        {

        }
    }

    public void HlMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
