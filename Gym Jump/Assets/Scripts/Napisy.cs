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
        string[] napisy = { "Kolikr�t to nasype�, tolikr�t jsi �lov�kem", "Everyday is chestday", "Eat. Sleep. Skip the legday. Repeat", "V tuku je s�la", "Sumo deadlift nen� deadlift", "Fuuuuu" };
        napis.text = napisy[nahodne];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
