using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public float delayTime;
    float currentTime;

    private void Start()
    {
        currentTime = delayTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            gameObject.GetComponent<Weapon>().Fire();
            currentTime = delayTime;
        }
    }
}
