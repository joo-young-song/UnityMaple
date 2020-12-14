// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Warrior"",
            ""id"": ""674a8305-bd70-406c-89ea-a7b3de6d3083"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e7858b8c-7952-4b52-8a71-fa22d7a6ba89"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e8c61769-ba50-45d6-8b15-2e928733b10e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2cf813fa-c3b6-4b9e-a5b3-c1333fb9822a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bbeec0de-81b6-49fd-9b61-96bad4a6fcf4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""66cd6e57-2616-4551-969d-ba3d973f16e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b18ac9ce-eb55-4688-b5ee-cd5c655f147b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""65519b52-1c99-4961-b8e6-d95503c02432"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c73be38-af46-4b62-bf73-ef6384692e6b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1014f268-8ee3-4821-b817-9f5909d5ed02"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee2584f8-9b36-4dda-9ec5-1ba004807cc6"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecdb0948-4d95-4259-a6cc-5c940963ae88"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Warrior
        m_Warrior = asset.FindActionMap("Warrior", throwIfNotFound: true);
        m_Warrior_Move = m_Warrior.FindAction("Move", throwIfNotFound: true);
        m_Warrior_Jump = m_Warrior.FindAction("Jump", throwIfNotFound: true);
        m_Warrior_Attack = m_Warrior.FindAction("Attack", throwIfNotFound: true);
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

    // Warrior
    private readonly InputActionMap m_Warrior;
    private IWarriorActions m_WarriorActionsCallbackInterface;
    private readonly InputAction m_Warrior_Move;
    private readonly InputAction m_Warrior_Jump;
    private readonly InputAction m_Warrior_Attack;
    public struct WarriorActions
    {
        private @PlayerControl m_Wrapper;
        public WarriorActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Warrior_Move;
        public InputAction @Jump => m_Wrapper.m_Warrior_Jump;
        public InputAction @Attack => m_Wrapper.m_Warrior_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Warrior; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WarriorActions set) { return set.Get(); }
        public void SetCallbacks(IWarriorActions instance)
        {
            if (m_Wrapper.m_WarriorActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_WarriorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public WarriorActions @Warrior => new WarriorActions(this);
    public interface IWarriorActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}