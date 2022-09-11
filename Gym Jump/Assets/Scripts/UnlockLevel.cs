using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UnlockLevel : MonoBehaviour
{
    public GameObject Colorization;

    public void Start()
    {
        for (int i = 2; i <= OpenLevel.activeLevel+1; i++)
        {
            Unlock(i);
        }
    }

    public void Unlock(int levelNumber)
    {
        Colorization.transform.GetChild(levelNumber - 1).gameObject.SetActive(false);
        this.transform.GetChild(levelNumber - 1).gameObject.SetActive(true);
    }
}
