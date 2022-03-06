using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemCounter : MonoBehaviour
{
    public Image fillCounter;
    public Text txtCounter;
    public Player player;
    public short itemCounter;
    short lateItemCounter = 0;

    public bool effect = false;

    float  maxTime = 2.5f, actualTime = 2.5f;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && itemCounter > 0 && !effect)
        {
            actualTime = maxTime;
            player.Itemy();
            effect = true;
            itemCounter--;
        }


        if(lateItemCounter != itemCounter)
        {
            txtCounter.text = itemCounter + "x";
            lateItemCounter = itemCounter;
        }

        if (effect)
        {
            actualTime -= Time.deltaTime;
            fillCounter.fillAmount = actualTime / maxTime;
        }

        if (fillCounter.fillAmount <= 0)
            effect = false;
    }
}
