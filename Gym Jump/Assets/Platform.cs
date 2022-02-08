using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpHeigh = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rg = collision.collider.GetComponent<Rigidbody2D>();
            if (rg != null)
            {
                Vector2 velocity = rg.velocity;
                velocity.y = jumpHeigh;
                rg.velocity = velocity;
            }
        }
    }
}
