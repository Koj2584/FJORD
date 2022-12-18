using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowing : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem snow;
    Vector3 spawnPos;
    void Start()
    {
        spawnPos = new(0, 7, 0);
        Instantiate(snow, spawnPos, Quaternion.identity, gameObject.transform);
        spawnPos.y += 7;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnPos.y < player.transform.position.y + 27)
        {
            Instantiate(snow, spawnPos, Quaternion.identity, gameObject.transform);
            spawnPos.y += 7;
        }
    }
}
