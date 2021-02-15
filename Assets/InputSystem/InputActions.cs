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
                    ""type"": ""Button"",
                    ""id"": ""51b52acd-7024-46a3-b756-ea4d797a3300"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fd35a9b-df47-4989-b980-203f655be150"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
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
    public struct InputsActions
    {
        private @InputActions m_Wrapper;
        public InputsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis => m_Wrapper.m_Inputs_Axis;
        public InputAction @Jump => m_Wrapper.m_Inputs_Jump;
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
            }
        }
    }
    public InputsActions @Inputs => new InputsActions(this);
    public interface IInputsActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
