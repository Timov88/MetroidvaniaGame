using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    private InputActions controls;
    private float triggerValue;
    public Vector2 movement;
    PlayerMovement playerMovement;

    void Awake()
    {
        controls = new InputActions();
        controls.Player.Jump.started += context => Jump();
        controls.Player.MoveKeyboard.started += context => MoveKeyboard();
    }

    void Start()
    {
        Debug.Log("asdasd");
        playerMovement = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        Vector2 axisInput = controls.Player.Move.ReadValue<Vector2>();
        movement = new Vector2 { x = axisInput.x, y = axisInput.y };
        playerMovement.Movement(movement);

        Debug.Log(movement);
        //movement.Normalize();
    }

    private void Jump()
    {
        playerMovement.Jump();
    }

    private void MoveKeyboard()
    {
        playerMovement.MoveKeyboard();
    }

    void OnEnable() {
        controls.Enable();
    }

     void OnDisable() {
        controls.Disable();
    }

}
