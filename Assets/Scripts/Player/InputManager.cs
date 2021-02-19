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
    public InputEventBool jumpInputEvent;
    public InputEventBool dashInputEvent;
    public InputEventBool parryInputEvent;
    public InputEventBool shootInputEvent;
    public InputEventVector2 moveInputEvent;

    private void Awake()
    {
        inputActions = new InputActions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Movement.performed += OnMove;
        inputActions.Player.Movement.canceled += OnMove;
        inputActions.Player.Jump.performed += OnJump;
        inputActions.Player.Dash.performed += OnDash;
        inputActions.Player.Shoot.performed += OnShoot;
        inputActions.Player.Parry.performed += OnParry;
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

    
    private void OnJump(InputAction.CallbackContext context)
    {
        bool jumpInput = context.ReadValueAsButton();
        jumpInputEvent.Invoke(jumpInput);
        //Debug.Log("KULLI");
    }

    private void OnDash(InputAction.CallbackContext context)
    {
        bool dashInput = context.ReadValueAsButton();
        dashInputEvent.Invoke(dashInput);
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        bool shootInput = context.ReadValueAsButton();
        shootInputEvent.Invoke(shootInput);
    }

    private void OnParry(InputAction.CallbackContext context)
    {
        bool parryInput = context.ReadValueAsButton();
        parryInputEvent.Invoke(parryInput);
    }
}
