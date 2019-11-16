using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPhysics : MonoBehaviour
{

    public event Action<Collision> CollisionEnterEvent;
    public event Action<Collision> CollisionExitEvent;

    void OnCollisionEnter(Collision collision)
    {
        CollisionEnterEvent.Invoke(collision);
    }

    void OnCollisionExit(Collision collision)
    {
        CollisionExitEvent.Invoke(collision);
    }
}
