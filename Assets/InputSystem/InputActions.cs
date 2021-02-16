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
            ""name"": ""Player1"",
            ""id"": ""67e22c6e-ef03-443f-b30a-fdad84078c57"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""e73af631-8a85-434a-9db1-69c928124c43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb840975-2f7f-48ea-8efd-dd4fe2ea86f0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bf7cf66-bd07-42b8-baed-90117ece4dd8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Newaction = m_Player1.FindAction("New action", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Newaction;
    public struct Player1Actions
    {
        private @InputActions m_Wrapper;
        public Player1Actions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Player1_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IInputsActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnNappi(InputAction.CallbackContext context);
        void OnLiikkumine(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
