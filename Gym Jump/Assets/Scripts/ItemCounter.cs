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
    float timer = 5f, time = 0f;

    Color nColor;

    private void Start()
    {
        nColor = fillCounter.color;
    }


    private void Update()
    {
        if (time >= timer)
        {
            if (fillCounter.color != nColor)
                fillCounter.color = nColor;

            if (Input.GetKeyDown(KeyCode.E) && itemCounter > 0 && !effect)
            {
                actualTime = maxTime;
                player.Itemy();
                effect = true;
                itemCounter--;
            }

            if (effect)
            {
                actualTime -= Time.deltaTime;
                fillCounter.fillAmount = actualTime / maxTime;
            }

            if (fillCounter.fillAmount <= 0)
            {
                effect = false;
                time = 0;
            }
        }
        else
        {
            if (fillCounter.color != Color.red)
                fillCounter.color = Color.red;
            time += Time.deltaTime;
            fillCounter.fillAmount = time / timer;
        }

        if (lateItemCounter != itemCounter)
        {
            txtCounter.text = itemCounter + "x";
            lateItemCounter = itemCounter;
        }
    }
}
