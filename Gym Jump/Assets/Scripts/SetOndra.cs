using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetOndra : MonoBehaviour
{

    public Toggle toggle;

    private void Start()
    {
        toggle.isOn = Optons.spravnejOndra;
    }
}
