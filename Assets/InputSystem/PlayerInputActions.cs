//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""acabed86-280a-4409-a367-81af93abcb68"",
            ""actions"": [
                {
                    ""name"": ""Propulsion"",
                    ""type"": ""Button"",
                    ""id"": ""0f5f2932-b4e2-421d-9f14-38fa202f62ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRotation"",
                    ""type"": ""Button"",
                    ""id"": ""95a46e72-35ce-46c0-867b-060ddc35359f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightRotation"",
                    ""type"": ""Button"",
                    ""id"": ""e0ea4ac2-c985-478a-aeec-beb5f8864632"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d938ef15-8ffb-4959-8e47-8a2ffa8b4d47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BulletTime"",
                    ""type"": ""Button"",
                    ""id"": ""f311f7b3-f1c5-4e48-8b1c-2f4c6e471bba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15387b1f-f01f-401f-9c18-26e7994846e7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38d6af62-a629-4434-b211-585974cf2a61"",
                    ""path"": ""<AndroidGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""LeftRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb910d5a-f1c6-45d8-b71d-7fa1dbb8915a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0758b739-1a5b-4ce4-988d-b63b98936eee"",
                    ""path"": ""<AndroidGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""RightRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8b12726-3d8a-48ec-a49e-992f761697f6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11bdcf5a-fe2d-472d-90b1-10ccd58b439f"",
                    ""path"": ""<AndroidGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc63e901-59aa-435f-be32-727fdbc67c37"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BulletTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35fa7efe-d639-495f-ad72-59008951ab2b"",
                    ""path"": ""<AndroidGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""BulletTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3b6067a-06f7-444c-8dba-397ba9d0eede"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Propulsion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""457097c9-e5bc-4f32-be97-276570b9cfd9"",
                    ""path"": ""<AndroidGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Propulsion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Propulsion = m_Player.FindAction("Propulsion", throwIfNotFound: true);
        m_Player_LeftRotation = m_Player.FindAction("LeftRotation", throwIfNotFound: true);
        m_Player_RightRotation = m_Player.FindAction("RightRotation", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_BulletTime = m_Player.FindAction("BulletTime", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Propulsion;
    private readonly InputAction m_Player_LeftRotation;
    private readonly InputAction m_Player_RightRotation;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_BulletTime;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Propulsion => m_Wrapper.m_Player_Propulsion;
        public InputAction @LeftRotation => m_Wrapper.m_Player_LeftRotation;
        public InputAction @RightRotation => m_Wrapper.m_Player_RightRotation;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @BulletTime => m_Wrapper.m_Player_BulletTime;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Propulsion.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPropulsion;
                @Propulsion.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPropulsion;
                @Propulsion.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPropulsion;
                @LeftRotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRotation;
                @LeftRotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRotation;
                @LeftRotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftRotation;
                @RightRotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRotation;
                @RightRotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRotation;
                @RightRotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightRotation;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @BulletTime.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBulletTime;
                @BulletTime.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBulletTime;
                @BulletTime.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBulletTime;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Propulsion.started += instance.OnPropulsion;
                @Propulsion.performed += instance.OnPropulsion;
                @Propulsion.canceled += instance.OnPropulsion;
                @LeftRotation.started += instance.OnLeftRotation;
                @LeftRotation.performed += instance.OnLeftRotation;
                @LeftRotation.canceled += instance.OnLeftRotation;
                @RightRotation.started += instance.OnRightRotation;
                @RightRotation.performed += instance.OnRightRotation;
                @RightRotation.canceled += instance.OnRightRotation;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @BulletTime.started += instance.OnBulletTime;
                @BulletTime.performed += instance.OnBulletTime;
                @BulletTime.canceled += instance.OnBulletTime;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPropulsion(InputAction.CallbackContext context);
        void OnLeftRotation(InputAction.CallbackContext context);
        void OnRightRotation(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnBulletTime(InputAction.CallbackContext context);
    }
}
