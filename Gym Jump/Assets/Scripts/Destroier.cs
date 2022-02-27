using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroier : MonoBehaviour
{
    GameObject destroier;

    private void Start()
    {
        destroier = GameObject.FindGameObjectWithTag("Destroier");
    }

    void Update()
    {
        if(destroier.transform.position.y >= gameObject.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
