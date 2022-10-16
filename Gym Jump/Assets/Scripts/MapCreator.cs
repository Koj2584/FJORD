using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject[] platforPrefab;
    public GameObject background;
    public new GameObject camera;
    public Transform delka;
    public GameObject[] items;
    public int Height;
    public float levelWidth;
    public float minY;
    public float maxY;

    void StartSetup()
    {
        levelWidth = 5f;
        minY = 1;
        switch (SceneMan.scene)
        {
            case 1: 
                Height = 150;
                maxY = 2f;
                break;
            case 2:
                Height = 250;
                maxY = 2f;
                break;
            case 3:
                Height = 400;
                maxY = 2.5f;
                break;
            case 4:
                Height = 550;
                maxY = 2.5f;
                break;
            case 5:
                Height = 750;
                maxY = 2.5f;
                break;
            case 6:
                Height = 950;
                maxY = 3f;
                break;
            case 7:
                Height = 1200;
                maxY = 3f;
                break;
            case 8:
                Height = 1450;
                maxY = 3f;
                break;
            case 9:
                Height = 1750;
                maxY = 3f;
                break;
            case 10:
                Height = 2150;
                maxY = 3f;
                break;
        }
    }

    void Start()
    {
        StartSetup();
        Vector3 spawnPos = new(0,-(maxY + 3),0);

        Debug.Log(gameObject.transform.position);

        for (int i = 0; spawnPos.y < Height; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            int platform = Random.Range(1, 20);
            if (platform == 2 || platform == 3)
                platform = 2;
            else if (platform == 4 || platform == 5)
            {
                platform = 4;
                spawnPos.x = 0;
            }
            else if (platform != 1)
                platform = 0;
            Instantiate(platforPrefab[platform], spawnPos, Quaternion.identity, gameObject.transform);
            if ((platform != 1 && platform != 4)&& (int)Random.Range(1, 25) == 1)
            {
                spawnPos.y += 1.1f;
                Instantiate(items[0], spawnPos, Quaternion.identity);
            }
        }
        spawnPos.y += Random.Range(minY, maxY);
        spawnPos.x = Random.Range(-levelWidth, levelWidth);
        Instantiate(platforPrefab[3], spawnPos, Quaternion.identity, gameObject.transform);
    }

    private void FixedUpdate()
    {
        background.transform.position = new Vector2(background.transform.position.x, camera.transform.position.y - delka.position.y / (Height + 6.5f) * camera.transform.position.y);
    }
}
