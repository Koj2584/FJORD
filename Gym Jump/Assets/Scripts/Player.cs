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
    public Transform border;
    public Animator anim;
    public Transform groundChack;
    public float checkRadius;
    public LayerMask whatIsGround;
    public itemUI text;

    public bool isActive = false;
    bool endActive = true;

    public int timer = -1;

    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Movment();

        Itemy();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundChack.position, checkRadius, whatIsGround);
        rg.velocity = new Vector2(movementX, rg.velocity.y);
    }

    void Itemy()
    {
        if (isActive && endActive)
        {
            isActive = false;
            endActive = false;
            movementSpeed += 4;
            jumpHigh += 3;
            text.SetItem("Bílá koule");
            Invoke("EndItem", 2.5f);
        }
        isActive = false;
    }

    void EndItem()
    {
        movementSpeed -= 4;
        jumpHigh -= 3;
        text.DelItem();
        endActive = true;
    }

    void Movment()
    {
        movementX = Input.GetAxis("Horizontal") * movementSpeed;
        if (isGrounded && Input.GetKey(KeyCode.Space) && rg.velocity.y <= 0.1)
        {
            rg.velocity = Vector2.up * jumpHigh;
        }
        if (rg.velocity.y >= 0.1)
            anim.SetBool("Skok", true);
        if (rg.velocity.y < 0)
            anim.SetBool("Skok", false);
        if (isGrounded)
            anim.SetBool("Ground", true);
        else
            anim.SetBool("Ground", false);
        if (movementX > 0)
        {
            transform.rotation = new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w);
            anim.SetBool("Chuze", true);
        }
        if (movementX < 0)
        {
            transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
            anim.SetBool("Chuze", true);
        }
        if (movementX == 0)
        {
            anim.SetBool("Chuze", false);

        }
        if (transform.position.x >= border.position.x)
        {
            transform.position = new Vector2(-(transform.position.x - 0.2f), transform.position.y);
        }
        if (transform.position.x <= -border.position.x)
        {
            transform.position = new Vector2(-(transform.position.x + 0.2f), transform.position.y);
        }
    }
}
