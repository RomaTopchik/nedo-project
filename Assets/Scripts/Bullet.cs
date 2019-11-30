using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private BulletTableObject bulletData;

    private void Start()
    {
        GetComponent<Material>().mainTexture = bulletData.Icon;
    }

    void OnCollisionEnter(Collision collision)
    {
        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.GetDamage(bulletData.Damage);

        }
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(transform.right * bulletData.Speed);
    }
}
