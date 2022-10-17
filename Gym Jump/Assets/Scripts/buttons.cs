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
            LoaderUI.SetActive(true);
            LoadScene(1);
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
            LoaderUI.SetActive(true);
            LoadScene(1);
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

    public GameObject LoaderUI;
    public Slider progressSlider;

    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }

    public IEnumerator LoadScene_Coroutine(int index)
    {
        progressSlider.value = 0;
        
        Debug.Log("zmrde");

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;

        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
