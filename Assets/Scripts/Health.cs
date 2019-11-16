using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Bullet"))
        {
            health -= 10;
            Destroy(collision.gameObject);
        }
        if (health <= 0)
            Destroy(gameObject);
    }
}
