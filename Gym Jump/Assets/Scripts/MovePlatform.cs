using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{


    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    Transform player;

    Vector3 nextPos;

    public global::System.Single Speed { get => speed; set => speed = value; }

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        player = GameObject.FindWithTag("Player").transform;
        this.transform.position = new Vector3(Random.Range(-6.5f, 6.5f), this.transform.position.y, this.transform.position.z);
        speed = Random.Range(1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;

        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, Speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rg = collision.collider.GetComponent<Rigidbody2D>();
            if (rg != null)
            {
                player.parent = this.transform;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        player.parent = null;
    }
}
