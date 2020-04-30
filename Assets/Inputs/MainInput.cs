// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/MainInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInput"",
    ""maps"": [
        {
            ""name"": ""Marker"",
            ""id"": ""27e1f24e-ff00-4f09-aca6-1ba0bb008c08"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b8e8147-5d2f-4e53-aca4-59ec0d48c6d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""081e1fd6-316b-4ed3-88f8-2446179416ac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e6b51cc-5a1d-4f29-8211-5ad0ae4387da"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KM"",
            ""bindingGroup"": ""KM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Marker
        m_Marker = asset.FindActionMap("Marker", throwIfNotFound: true);
        m_Marker_Tap = m_Marker.FindAction("Tap", throwIfNotFound: true);
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

    // Marker
    private readonly InputActionMap m_Marker;
    private IMarkerActions m_MarkerActionsCallbackInterface;
    private readonly InputAction m_Marker_Tap;
    public struct MarkerActions
    {
        private @MainInput m_Wrapper;
        public MarkerActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_Marker_Tap;
        public InputActionMap Get() { return m_Wrapper.m_Marker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MarkerActions set) { return set.Get(); }
        public void SetCallbacks(IMarkerActions instance)
        {
            if (m_Wrapper.m_MarkerActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_MarkerActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_MarkerActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_MarkerActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_MarkerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public MarkerActions @Marker => new MarkerActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("KM");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    public interface IMarkerActions
    {
        void OnTap(InputAction.CallbackContext context);
    }
}
