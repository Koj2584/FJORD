using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPlatform : MonoBehaviour
{
    public GameObject win;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rg = collision.collider.GetComponent<Rigidbody2D>();
            if (rg != null)
            {
                Time.timeScale = 0f;
                Instantiate(win,GameObject.FindGameObjectWithTag("Canvas").transform);
                Cursor.visible = true;
            }
        }
    }
}
