using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float damage = 5;

    [SerializeField]
    private float speed = 5;

    void OnCollisionEnter(Collision collision)
    {
        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.GetDamage(damage);

        }
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(transform.right * speed);
    }
}
