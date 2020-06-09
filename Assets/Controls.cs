// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""13c255c0-0c29-4f40-a3f6-165b23e35f1f"",
            ""actions"": [
                {
                    ""name"": ""OpenWheel"",
                    ""type"": ""Button"",
                    ""id"": ""fd90b2fa-b608-43ba-a344-c560bcc29273"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0cf86990-59f7-4cac-8a8e-87f66c8b71a9"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Wheel"",
            ""id"": ""44bb5bab-4795-42e0-a5ee-b52394f55177"",
            ""actions"": [
                {
                    ""name"": ""CloseWheel"",
                    ""type"": ""Button"",
                    ""id"": ""53525806-3f3e-4928-b747-e8d4898b3367"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectWheelSegment"",
                    ""type"": ""Value"",
                    ""id"": ""48ce4d0b-85be-45ff-ae3a-fa4cb93b35de"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5af03b8a-d2e2-4331-9a21-16ecfc055e2e"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2a63da99-8574-419d-a786-efe3a6c1315c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWheelSegment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""66e04a44-a374-454a-bb99-d44fd75c2a9e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWheelSegment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1167ca38-a148-4543-89cf-dc18f0201b42"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWheelSegment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b08390ba-df2f-49a2-b07b-b948f61413dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWheelSegment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a61f2f6-16d1-4356-bdac-e54cbf57daae"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWheelSegment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_OpenWheel = m_Main.FindAction("OpenWheel", throwIfNotFound: true);
        // Wheel
        m_Wheel = asset.FindActionMap("Wheel", throwIfNotFound: true);
        m_Wheel_CloseWheel = m_Wheel.FindAction("CloseWheel", throwIfNotFound: true);
        m_Wheel_SelectWheelSegment = m_Wheel.FindAction("SelectWheelSegment", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_OpenWheel;
    public struct MainActions
    {
        private @Controls m_Wrapper;
        public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenWheel => m_Wrapper.m_Main_OpenWheel;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @OpenWheel.started -= m_Wrapper.m_MainActionsCallbackInterface.OnOpenWheel;
                @OpenWheel.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnOpenWheel;
                @OpenWheel.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnOpenWheel;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenWheel.started += instance.OnOpenWheel;
                @OpenWheel.performed += instance.OnOpenWheel;
                @OpenWheel.canceled += instance.OnOpenWheel;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // Wheel
    private readonly InputActionMap m_Wheel;
    private IWheelActions m_WheelActionsCallbackInterface;
    private readonly InputAction m_Wheel_CloseWheel;
    private readonly InputAction m_Wheel_SelectWheelSegment;
    public struct WheelActions
    {
        private @Controls m_Wrapper;
        public WheelActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseWheel => m_Wrapper.m_Wheel_CloseWheel;
        public InputAction @SelectWheelSegment => m_Wrapper.m_Wheel_SelectWheelSegment;
        public InputActionMap Get() { return m_Wrapper.m_Wheel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WheelActions set) { return set.Get(); }
        public void SetCallbacks(IWheelActions instance)
        {
            if (m_Wrapper.m_WheelActionsCallbackInterface != null)
            {
                @CloseWheel.started -= m_Wrapper.m_WheelActionsCallbackInterface.OnCloseWheel;
                @CloseWheel.performed -= m_Wrapper.m_WheelActionsCallbackInterface.OnCloseWheel;
                @CloseWheel.canceled -= m_Wrapper.m_WheelActionsCallbackInterface.OnCloseWheel;
                @SelectWheelSegment.started -= m_Wrapper.m_WheelActionsCallbackInterface.OnSelectWheelSegment;
                @SelectWheelSegment.performed -= m_Wrapper.m_WheelActionsCallbackInterface.OnSelectWheelSegment;
                @SelectWheelSegment.canceled -= m_Wrapper.m_WheelActionsCallbackInterface.OnSelectWheelSegment;
            }
            m_Wrapper.m_WheelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseWheel.started += instance.OnCloseWheel;
                @CloseWheel.performed += instance.OnCloseWheel;
                @CloseWheel.canceled += instance.OnCloseWheel;
                @SelectWheelSegment.started += instance.OnSelectWheelSegment;
                @SelectWheelSegment.performed += instance.OnSelectWheelSegment;
                @SelectWheelSegment.canceled += instance.OnSelectWheelSegment;
            }
        }
    }
    public WheelActions @Wheel => new WheelActions(this);
    public interface IMainActions
    {
        void OnOpenWheel(InputAction.CallbackContext context);
    }
    public interface IWheelActions
    {
        void OnCloseWheel(InputAction.CallbackContext context);
        void OnSelectWheelSegment(InputAction.CallbackContext context);
    }
}
