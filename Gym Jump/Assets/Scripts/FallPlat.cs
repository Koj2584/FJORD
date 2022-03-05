using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
    Rigidbody2D rb;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.y < 0)
        {
            Invoke("DropPlatform", 0.25f);
            Destroy(gameObject, 2f);

        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;

    }
}
