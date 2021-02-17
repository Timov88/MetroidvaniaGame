// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Inputs"",
            ""id"": ""41902c48-2e54-4c73-b3a6-b9e5d9fdcad9"",
            ""actions"": [
                {
                    ""name"": ""Axis"",
                    ""type"": ""Value"",
                    ""id"": ""8c5f0e27-6f56-46f9-8e12-03c5444914c4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""51b52acd-7024-46a3-b756-ea4d797a3300"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Nappi"",
                    ""type"": ""Value"",
                    ""id"": ""b56941d8-bb1d-4bc6-b9bf-b9532e5001bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Liikkumine"",
                    ""type"": ""Button"",
                    ""id"": ""7f77bcc4-604b-4822-9093-b45eada790ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4846d64-538a-4a8b-b7d0-3bea0bd20773"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94eaf6b2-436d-49a5-8020-0c75f59429c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fd35a9b-df47-4989-b980-203f655be150"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ff2e2f5-02b3-4ffe-a696-07ac58ae7a67"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f862775-d977-4ca7-8380-89dbdd57531d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Nappi"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4577e65b-e04e-4469-a5c0-10468887919f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Liikkumine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1809137-be38-4757-a4c6-18a7f8af377b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Liikkumine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""67e22c6e-ef03-443f-b30a-fdad84078c57"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""e73af631-8a85-434a-9db1-69c928124c43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c8d2f276-9e94-4eaa-8a43-4e567f3083fe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""cebaaed7-0906-4e77-a880-4b4a163a9137"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""98143bed-c34c-4b9c-93a9-c5f211ebcfb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""9d10ec93-0acc-4350-acb5-b762c331267e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2e1b3b08-137b-4042-be95-666c49c90db2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a9597f3-1568-4ff9-bbca-4e8c36e11cc7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4af68372-266d-4aae-a483-f770353b53a6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f077ce4f-341d-4b9e-b6ce-651467aadd58"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a9de6e7-8a8f-4677-9504-33b24491a96e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e86931e8-79b7-4bb4-97fa-963d8d505f4c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaf2a74a-3d6b-4825-b557-896542a51724"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b22af71c-4a6a-4352-9334-15b87ea80e69"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""093f6df6-a911-48d6-b8f6-78297afabbf3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2f2b213-4742-4d10-80cc-7b1e5de085b0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2daf979-21ab-4dd9-b7cb-7705c3c4b4c1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ccedf578-217d-4bb6-9948-b6a60c088a52"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""661d4b11-e7e9-4001-b871-73b0a68148ff"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ccadc1da-7c95-4761-b2aa-6715bde38382"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2207f1de-546b-4276-9cb9-970c3348e1a5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6cee4508-c642-4eab-84f7-c68f9ef3b80d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Inputs
        m_Inputs = asset.FindActionMap("Inputs", throwIfNotFound: true);
        m_Inputs_Axis = m_Inputs.FindAction("Axis", throwIfNotFound: true);
        m_Inputs_Jump = m_Inputs.FindAction("Jump", throwIfNotFound: true);
        m_Inputs_Nappi = m_Inputs.FindAction("Nappi", throwIfNotFound: true);
        m_Inputs_Liikkumine = m_Inputs.FindAction("Liikkumine", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Melee = m_Player.FindAction("Melee", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_MoveKeyboard = m_Player.FindAction("MoveKeyboard", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Inputs
    private readonly InputActionMap m_Inputs;
    private IInputsActions m_InputsActionsCallbackInterface;
    private readonly InputAction m_Inputs_Axis;
    private readonly InputAction m_Inputs_Jump;
    private readonly InputAction m_Inputs_Nappi;
    private readonly InputAction m_Inputs_Liikkumine;
    public struct InputsActions
    {
        private @InputActions m_Wrapper;
        public InputsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis => m_Wrapper.m_Inputs_Axis;
        public InputAction @Jump => m_Wrapper.m_Inputs_Jump;
        public InputAction @Nappi => m_Wrapper.m_Inputs_Nappi;
        public InputAction @Liikkumine => m_Wrapper.m_Inputs_Liikkumine;
        public InputActionMap Get() { return m_Wrapper.m_Inputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputsActions set) { return set.Get(); }
        public void SetCallbacks(IInputsActions instance)
        {
            if (m_Wrapper.m_InputsActionsCallbackInterface != null)
            {
                @Axis.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnAxis;
                @Axis.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnAxis;
                @Axis.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnAxis;
                @Jump.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnJump;
                @Nappi.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnNappi;
                @Nappi.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnNappi;
                @Nappi.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnNappi;
                @Liikkumine.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnLiikkumine;
                @Liikkumine.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnLiikkumine;
                @Liikkumine.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnLiikkumine;
            }
            m_Wrapper.m_InputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Axis.started += instance.OnAxis;
                @Axis.performed += instance.OnAxis;
                @Axis.canceled += instance.OnAxis;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Nappi.started += instance.OnNappi;
                @Nappi.performed += instance.OnNappi;
                @Nappi.canceled += instance.OnNappi;
                @Liikkumine.started += instance.OnLiikkumine;
                @Liikkumine.performed += instance.OnLiikkumine;
                @Liikkumine.canceled += instance.OnLiikkumine;
            }
        }
    }
    public InputsActions @Inputs => new InputsActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Melee;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_MoveKeyboard;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Melee => m_Wrapper.m_Player_Melee;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @MoveKeyboard => m_Wrapper.m_Player_MoveKeyboard;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Melee.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @MoveKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MoveKeyboard.started += instance.OnMoveKeyboard;
                @MoveKeyboard.performed += instance.OnMoveKeyboard;
                @MoveKeyboard.canceled += instance.OnMoveKeyboard;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IInputsActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnNappi(InputAction.CallbackContext context);
        void OnLiikkumine(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMoveKeyboard(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
