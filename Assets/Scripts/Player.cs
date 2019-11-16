using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private MovementController movementController;

    private void OnEnable()
    {
        InputController.InputDataEvent += movementController.GetInputData;
    }

    private void OnDisable()
    {
        InputController.InputDataEvent -= movementController.GetInputData;
    }

}
