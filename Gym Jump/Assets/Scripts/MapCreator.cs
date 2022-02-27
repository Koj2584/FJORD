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
    public int Height = 150;
    public float levelWidth = 5f;
    public float minY = 1;
    public float maxY = 2f;

    void Start()
    {
        Vector3 spawnPos = new Vector3();
        spawnPos.y -= 3.5f;

        for (int i = 0; spawnPos.y < Height; i++)
        {
            int platform = Random.Range(1, 20);
            if (platform != 1)
                platform = 0;
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platforPrefab[platform], spawnPos, Quaternion.identity, gameObject.transform);
        }
        spawnPos.y += Random.Range(minY, maxY);
        spawnPos.x = Random.Range(-levelWidth, levelWidth);
        Instantiate(platforPrefab[2], spawnPos, Quaternion.identity, gameObject.transform);
    }

    private void FixedUpdate()
    {
        background.transform.position = new Vector2(background.transform.position.x, camera.transform.position.y - delka.position.y / (Height + 6.5f) * camera.transform.position.y);
    }
}
