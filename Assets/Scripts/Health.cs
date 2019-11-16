using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamagable
{
    public float health;

    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
            Destroy(gameObject);
    }

    
}

public interface IDamagable
{
    void GetDamage(float damage);

}
