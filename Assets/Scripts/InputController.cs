using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{

    public static event Action<InputData> InputDataEvent;

    private IInputType inputType;

    private void Start()
    {
        inputType = new KeyboardInput();
    }

    private void Update()
    {
        InputDataEvent.Invoke(inputType.GetInputVector());
    }

}


public interface IInputType
{
    InputData GetInputVector();
}


public class KeyboardInput : IInputType
{
    float moveHorizontal;
    Vector3 movement;
    bool isJump;

    public InputData GetInputVector()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector3(moveHorizontal, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }
        else
        {
            isJump = false;
        }
        


        return new InputData(isJump, movement);
    }
}

public struct InputData
{
    public bool isJump;
    public Vector3 moveVector;

    public InputData(bool isJump, Vector3 moveVector)
    {
        this.isJump = isJump;
        this.moveVector = moveVector;
    }
        
}


