using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name);
        print("you pass the red traffic");
    }
}
