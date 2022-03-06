using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    ItemCounter itemCounter;
    private void Start()
    {
        itemCounter = ItemCounter.FindObjectOfType<ItemCounter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            itemCounter.itemCounter++;
        }

        if (collision.gameObject.layer == LayerMask.GetMask("Ground"));
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
