using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class itemUI : MonoBehaviour
{
    public Text text;
    public void SetItem(string itemName)
    {
        text.text += itemName+"\n";
    }

    public void DelItem()
    {
        text.text = "";
    }
}
