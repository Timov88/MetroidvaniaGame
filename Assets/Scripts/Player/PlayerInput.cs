using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    //PlayerMove playerMove;
    //InputActions inputActions;
    private InputActions controls;
    private float triggerValue;

    void Awake()
    {
        //inputActions = new InputActions();
        //playerMove = GetComponent<PlayerMove>();
        controls = new InputActions();
        
        //controls.Inputs.Jump.performed += ctx => Jump();
        //inputActions.Inputs.Jump.canceled += ctx => JumpCanceled();

        controls.Inputs.Jump.performed += context => triggerValue = context.ReadValue<float>();
        controls.Inputs.Jump.canceled += context => triggerValue = 0f;
        controls.Inputs.Jump.started += context => Jump();
        controls.Inputs.Jump.canceled += context => JumpOff();

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("asdasd");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Kulli Value: " + triggerValue);
        Vector2 axisInput = controls.Inputs.Axis.ReadValue<Vector2>();
        Vector2 movement = new Vector2 { x = axisInput.x, y = axisInput.y };
        movement.Normalize();
        Debug.Log("ISO" + axisInput);
        Debug.Log(movement);
    }

    private void Jump()
    {
        Debug.Log("Kulli ON");
        //playerMove.Jump();
    }

    private void JumpOff()
    {
        Debug.Log("Kulli OFF");
    }

    void OnEnable() {
        controls.Enable();
    }

     void OnDisable() {
        controls.Disable();
    }

}
