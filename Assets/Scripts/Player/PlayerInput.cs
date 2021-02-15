using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerMove playerMove;
    InputActions inputActions;
    void Awake()
    {
        Debug.Log("AWAKE TOIMII");
        inputActions = new InputActions();
        playerMove = GetComponent<PlayerMove>();
        
        inputActions.Inputs.Jump.performed += ctx => Jump();
        //inputActions.Inputs.Jump.canceled += ctx => JumpCanceled();

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("asdasd");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 axisInput = inputActions.Inputs.Axis.ReadValue<Vector2>();
        Vector2 movement = new Vector2 { x = axisInput.x, y = axisInput.y };
        movement.Normalize();
    }

    void Jump()
    {
        Debug.Log("asdasd");
        playerMove.Jump();
    }


}
