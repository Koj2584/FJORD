using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text txt;
    float start;
    int score;

    private void Start()
    {
        start = -player.transform.position.y;
        score = (int)(player.transform.position.y + start);
    }

    void Update()
    {
        score = (int)(player.transform.position.y + start);
        if (int.Parse(txt.text) < score)
        {
            txt.text = score.ToString();
        }
    }
}
