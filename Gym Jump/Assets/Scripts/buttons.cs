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
            SceneMan.scene = int.Parse(gameObject.name);
            SceneManager.LoadScene(1);
        }
        catch
        {

        }
    }

    public void Ranked()
    {
        SceneManager.LoadScene(2);
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

    public void NextLvl()
    {
        try
        {
            SceneMan.scene++;
            Debug.Log(SceneMan.scene);
            Time.timeScale = 1;
            SceneManager.LoadScene(1);
        }
        catch
        {

        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
