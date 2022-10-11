using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float jumpHeight = 20f;
    public AudioSource audio;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rg = collision.collider.GetComponent<Rigidbody2D>();
            if (rg != null)
            {
                rg.velocity = new Vector2(rg.velocity.x, jumpHeight);
                audio.Play();
            }
        }
    }
}
