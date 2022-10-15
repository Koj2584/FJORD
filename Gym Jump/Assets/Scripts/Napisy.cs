using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Napisy : MonoBehaviour
{
    public Text napis;
    void Start()
    {
        int nahodne = Random.Range(0, 5);
        string[] napisy = { "Kolikrát to nasypeš, tolikrát jsi èlovìkem", "Everyday is chestday", "Eat. Sleep. Skip the legday. Repeat", "V tuku je síla", "Sumo deadlift není deadlift", "Fuuuuu" };
        napis.text = napisy[nahodne];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
