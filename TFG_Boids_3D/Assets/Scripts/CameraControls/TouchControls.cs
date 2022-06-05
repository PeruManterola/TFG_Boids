// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/TouchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""bc169d18-1ac6-4def-b2a5-5a62ed53a7f6"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""76293994-60aa-4df4-bac8-c4ed386e16a0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""98478731-f4d6-4524-ac14-3e9186d1c3c9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""4156077e-4012-416c-8305-bb9e6997b746"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PrimaryContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""be0b5b95-8148-4cb7-acaf-fb9f1120e465"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PrimaryPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8c9c5f5-a6e3-4749-b7cf-bcf295ff2665"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cdf7f6e3-9256-448e-8e05-fe57d24fae5c"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""800b703d-c0d4-4eb6-9bb9-b43c12e57d36"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ffe8783-2cf3-48ff-b019-28d4209c0ab4"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70f79a2e-909a-4092-926f-e1e0df392f79"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b42ae8a5-1253-4b9c-94c1-34100761650b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFingerPosition = m_Touch.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryFingerPosition = m_Touch.FindAction("SecondaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
        m_Touch_PrimaryContact = m_Touch.FindAction("PrimaryContact", throwIfNotFound: true);
        m_Touch_PrimaryPosition = m_Touch.FindAction("PrimaryPosition", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_PrimaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    private readonly InputAction m_Touch_PrimaryContact;
    private readonly InputAction m_Touch_PrimaryPosition;
    public struct TouchActions
    {
        private @TouchControls m_Wrapper;
        public TouchActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Touch_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Touch_SecondaryFingerPosition;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputAction @PrimaryContact => m_Wrapper.m_Touch_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_Touch_PrimaryPosition;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryTouchContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @PrimaryContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
                @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
                @PrimaryContact.started += instance.OnPrimaryContact;
                @PrimaryContact.performed += instance.OnPrimaryContact;
                @PrimaryContact.canceled += instance.OnPrimaryContact;
                @PrimaryPosition.started += instance.OnPrimaryPosition;
                @PrimaryPosition.performed += instance.OnPrimaryPosition;
                @PrimaryPosition.canceled += instance.OnPrimaryPosition;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
}
