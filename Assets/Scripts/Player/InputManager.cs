using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[System.Serializable]
public class InputEventVector2 : UnityEvent<float, float> { }

[System.Serializable]
public class InputEventBool : UnityEvent<bool> { }


public sealed class InputManager : MonoBehaviour
{
    private InputActions inputActions;
    //public InputEventBool crouchInputEvent;
    public InputEventVector2 moveInputEvent;
    //public InputEventBool runInputEvent;

    private void Awake()
    {
        inputActions = new InputActions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Movement.performed += OnMove;
        inputActions.Player.Movement.canceled += OnMove;
        //controls.Gameplay.Crouch.canceled += OnCrouch;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);

        //Vector2 axisInput = context.ReadValue<Vector2>();
        //movement = new Vector2 (axisInput.x, axisInput.y);
        //playerMovement.Movement(movement);
        //Debug.Log($"Move Input: {moveInput}");
    }
}
