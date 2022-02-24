using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject[] platforPrefab;
    public GameObject background;
    public GameObject camera;
    public Transform delka;
    //public GameObject konec;
    float vyskaMapy = 0;
    public int numberOfPlatforms = 150;
    public float levelWidth = 5f;
    public float minY = .5f;
    public float maxY = 3.5f;

    void Start()
    {
        Vector3 spawnPos = new Vector3();
        spawnPos.y -= 3.5f;

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            int platform = Random.Range(1, 20);
            if (platform != 1)
                platform = 0;
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platforPrefab[platform], spawnPos, Quaternion.identity);
        }
        vyskaMapy = spawnPos.y;
        int platform1 = Random.Range(1, 20);
        if (platform1 != 1)
            platform1 = 0;
        spawnPos.y += Random.Range(minY, maxY);
        spawnPos.x = Random.Range(-levelWidth, levelWidth);
    }

    private void FixedUpdate()
    {
        background.transform.position = new Vector2(background.transform.position.x, camera.transform.position.y - delka.position.y/vyskaMapy*camera.transform.position.y);
    }
}
