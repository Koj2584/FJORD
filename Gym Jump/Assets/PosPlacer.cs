using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosPlacer : MonoBehaviour
{
    public Transform parent;
    void Start()
    {
        float random = Random.Range(-4.8f, 4.8f);
        if(random>=0&&parent.transform.position.x>=0)
            this.transform.position = new Vector3(random - parent.transform.position.x, parent.transform.position.y, parent.transform.position.z);
        else if (random >= 0 && parent.transform.position.x <= 0)
            this.transform.position = new Vector3(random + parent.transform.position.x, parent.transform.position.y, parent.transform.position.z);
        else if (random <= 0 && parent.transform.position.x >= 0)
            this.transform.position = new Vector3(random + parent.transform.position.x, parent.transform.position.y, parent.transform.position.z);
        else if (random <= 0 && parent.transform.position.x <= 0)
            this.transform.position = new Vector3(random - parent.transform.position.x, parent.transform.position.y, parent.transform.position.z);
    }
}
