using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 8f;
    public float jumpHigh = 11f;
    float movementX = 0f;
    public bool isGrounded = false;

    Rigidbody2D rg;
    public Transform groundChack;
    public float checkRadius;
    public LayerMask whatIsGround;

    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movementX = Input.GetAxis("Horizontal")*movementSpeed;
        if (isGrounded && Input.GetKey(KeyCode.Space))
            rg.velocity = Vector2.up * jumpHigh;
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundChack.position, checkRadius, whatIsGround);
        rg.velocity = new Vector2(movementX, rg.velocity.y);
    }
}
