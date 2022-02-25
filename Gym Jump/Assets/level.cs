using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class level : MonoBehaviour
{
    public Text num;

    public void StartLvl()
    {
        try
        {
            SceneManager.LoadScene(int.Parse(num.text));
                } catch
        {

        }
    }
}
