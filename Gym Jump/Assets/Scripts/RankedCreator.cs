using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankedCreator : MonoBehaviour
{
    public GameObject player;
    public GameObject[] platforPrefab;
    public GameObject background;
    public new GameObject camera;
    public Transform delka;
    public GameObject[] items;
    public float levelWidth;
    public float minY;
    public float maxY;
    Vector3 spawnPos;

    void StartSetup()
    {
        levelWidth = 5f;
        minY = 1;
        maxY = 2f;
    }

    void Start()
    {
        StartSetup();
        spawnPos = new(0, -(maxY + 3), 0);

        Debug.Log(player.transform.position.y);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
            Debug.Log(player.transform.position.y+" <--player ");
        if (spawnPos.y < player.transform.position.y+20)
        {
            int platform = Random.Range(1, 20);
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            if (platform == 2 || platform == 3)
                platform = 2;
            else if (platform == 4 || platform == 5)
            {
                platform = 3;
                spawnPos.x = 0;
            }
            else if (platform != 1)
                platform = 0;
            Instantiate(platforPrefab[platform], spawnPos, Quaternion.identity, gameObject.transform);
            if (platform != 1 && platform != 3 && (int)Random.Range(1, 25) == 1)
            {
                spawnPos.y += 1.1f;
                Instantiate(items[0], spawnPos, Quaternion.identity);
            }
        }
    }

    private void FixedUpdate()
    {
        background.transform.position = new Vector2(background.transform.position.x, camera.transform.position.y - delka.position.y / (1000 + 6.5f) * camera.transform.position.y);
    }
}
