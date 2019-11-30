using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();

    }

    public void Fire()
    {
        Bullet bl = Instantiate(bullet, new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z), Quaternion.identity).GetComponent<Bullet>();

        



        //if (gameObject.GetComponent<SpriteRenderer>().flipX)
        //{
        //    GameObject bl = Instantiate(bullet, new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z), Quaternion.identity);
        //    bl.GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * speedBullet;
        //}
        //else
        //{
        //    GameObject bl = Instantiate(bullet, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z), Quaternion.identity);
        //    bl.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0) * speedBullet;
        //}
    }
}
