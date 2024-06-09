//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/PlayerInputAction.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""27a8fdba-6ab9-457b-980c-a4209baee2d9"",
            ""actions"": [
                {
                    ""name"": ""InputDirections"",
                    ""type"": ""Value"",
                    ""id"": ""2014308f-dd6f-4ceb-954e-572eece580f6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpacePressed"",
                    ""type"": ""Button"",
                    ""id"": ""5e6bd073-a8bb-4afa-a083-b825671640ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ControlPressed"",
                    ""type"": ""Button"",
                    ""id"": ""63161bee-75dc-4943-b2d4-78d582a9ebe5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Value"",
                    ""id"": ""3dd178c7-33f9-4f7a-8904-6696f299a47a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Input2DAxes"",
                    ""id"": ""a01f71a4-49c0-4e50-b20b-d24f6a72d6cb"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputDirections"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5366b392-422f-48e4-9a32-dfcef4152e9f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""InputDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e1afc52f-e9f5-41ff-bab1-808566d3fe17"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""InputDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""03b688b8-a761-45d0-af50-3750cd528203"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""InputDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9c209c65-8966-42bb-bca7-49417f5e2ce5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""InputDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""337ff8d6-3b05-41c1-99f1-6bfc03ce7e4f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""SpacePressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edd19d3f-a333-499d-950a-958b9921f841"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""ControlPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47cd3fa8-713c-4ac8-bb1c-ae8f127cb3b9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""248e5a9a-0a5b-4db6-94b3-ff617eaab6c1"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""9f3a3106-d1b9-4f56-acba-c63ce9d67983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad951160-ada7-44b4-a246-dbe0530834b4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Fight"",
            ""id"": ""ef47c542-da1a-4348-8dc4-dd3dccb352e5"",
            ""actions"": [
                {
                    ""name"": ""LeftMouseButtonPressed"",
                    ""type"": ""Button"",
                    ""id"": ""b1bfbd8e-1c02-4edb-8cf6-50d0d9b581a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightMouseButtonPressed"",
                    ""type"": ""Button"",
                    ""id"": ""3750a407-ac09-469f-9ae6-3099d3c323f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe3b3c07-a000-48ed-a163-0720abf8f6b7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""LeftMouseButtonPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce43d0b8-d2a9-4f2c-9779-b0d1fab1ead2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""RightMouseButtonPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Base"",
            ""id"": ""233dcc89-d463-49e8-ae6a-6976c728e8a0"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""e03f0c5a-3a50-471a-984a-65e108765917"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""893d494a-54ea-48be-acfe-3e8ef33897f9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_InputDirections = m_Movement.FindAction("InputDirections", throwIfNotFound: true);
        m_Movement_SpacePressed = m_Movement.FindAction("SpacePressed", throwIfNotFound: true);
        m_Movement_ControlPressed = m_Movement.FindAction("ControlPressed", throwIfNotFound: true);
        m_Movement_Shift = m_Movement.FindAction("Shift", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_Newaction = m_Interaction.FindAction("New action", throwIfNotFound: true);
        // Fight
        m_Fight = asset.FindActionMap("Fight", throwIfNotFound: true);
        m_Fight_LeftMouseButtonPressed = m_Fight.FindAction("LeftMouseButtonPressed", throwIfNotFound: true);
        m_Fight_RightMouseButtonPressed = m_Fight.FindAction("RightMouseButtonPressed", throwIfNotFound: true);
        // Base
        m_Base = asset.FindActionMap("Base", throwIfNotFound: true);
        m_Base_MousePosition = m_Base.FindAction("MousePosition", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_InputDirections;
    private readonly InputAction m_Movement_SpacePressed;
    private readonly InputAction m_Movement_ControlPressed;
    private readonly InputAction m_Movement_Shift;
    public struct MovementActions
    {
        private @PlayerInputAction m_Wrapper;
        public MovementActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputDirections => m_Wrapper.m_Movement_InputDirections;
        public InputAction @SpacePressed => m_Wrapper.m_Movement_SpacePressed;
        public InputAction @ControlPressed => m_Wrapper.m_Movement_ControlPressed;
        public InputAction @Shift => m_Wrapper.m_Movement_Shift;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @InputDirections.started += instance.OnInputDirections;
            @InputDirections.performed += instance.OnInputDirections;
            @InputDirections.canceled += instance.OnInputDirections;
            @SpacePressed.started += instance.OnSpacePressed;
            @SpacePressed.performed += instance.OnSpacePressed;
            @SpacePressed.canceled += instance.OnSpacePressed;
            @ControlPressed.started += instance.OnControlPressed;
            @ControlPressed.performed += instance.OnControlPressed;
            @ControlPressed.canceled += instance.OnControlPressed;
            @Shift.started += instance.OnShift;
            @Shift.performed += instance.OnShift;
            @Shift.canceled += instance.OnShift;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @InputDirections.started -= instance.OnInputDirections;
            @InputDirections.performed -= instance.OnInputDirections;
            @InputDirections.canceled -= instance.OnInputDirections;
            @SpacePressed.started -= instance.OnSpacePressed;
            @SpacePressed.performed -= instance.OnSpacePressed;
            @SpacePressed.canceled -= instance.OnSpacePressed;
            @ControlPressed.started -= instance.OnControlPressed;
            @ControlPressed.performed -= instance.OnControlPressed;
            @ControlPressed.canceled -= instance.OnControlPressed;
            @Shift.started -= instance.OnShift;
            @Shift.performed -= instance.OnShift;
            @Shift.canceled -= instance.OnShift;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private List<IInteractionActions> m_InteractionActionsCallbackInterfaces = new List<IInteractionActions>();
    private readonly InputAction m_Interaction_Newaction;
    public struct InteractionActions
    {
        private @PlayerInputAction m_Wrapper;
        public InteractionActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Interaction_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void AddCallbacks(IInteractionActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IInteractionActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractionActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);

    // Fight
    private readonly InputActionMap m_Fight;
    private List<IFightActions> m_FightActionsCallbackInterfaces = new List<IFightActions>();
    private readonly InputAction m_Fight_LeftMouseButtonPressed;
    private readonly InputAction m_Fight_RightMouseButtonPressed;
    public struct FightActions
    {
        private @PlayerInputAction m_Wrapper;
        public FightActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftMouseButtonPressed => m_Wrapper.m_Fight_LeftMouseButtonPressed;
        public InputAction @RightMouseButtonPressed => m_Wrapper.m_Fight_RightMouseButtonPressed;
        public InputActionMap Get() { return m_Wrapper.m_Fight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FightActions set) { return set.Get(); }
        public void AddCallbacks(IFightActions instance)
        {
            if (instance == null || m_Wrapper.m_FightActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FightActionsCallbackInterfaces.Add(instance);
            @LeftMouseButtonPressed.started += instance.OnLeftMouseButtonPressed;
            @LeftMouseButtonPressed.performed += instance.OnLeftMouseButtonPressed;
            @LeftMouseButtonPressed.canceled += instance.OnLeftMouseButtonPressed;
            @RightMouseButtonPressed.started += instance.OnRightMouseButtonPressed;
            @RightMouseButtonPressed.performed += instance.OnRightMouseButtonPressed;
            @RightMouseButtonPressed.canceled += instance.OnRightMouseButtonPressed;
        }

        private void UnregisterCallbacks(IFightActions instance)
        {
            @LeftMouseButtonPressed.started -= instance.OnLeftMouseButtonPressed;
            @LeftMouseButtonPressed.performed -= instance.OnLeftMouseButtonPressed;
            @LeftMouseButtonPressed.canceled -= instance.OnLeftMouseButtonPressed;
            @RightMouseButtonPressed.started -= instance.OnRightMouseButtonPressed;
            @RightMouseButtonPressed.performed -= instance.OnRightMouseButtonPressed;
            @RightMouseButtonPressed.canceled -= instance.OnRightMouseButtonPressed;
        }

        public void RemoveCallbacks(IFightActions instance)
        {
            if (m_Wrapper.m_FightActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFightActions instance)
        {
            foreach (var item in m_Wrapper.m_FightActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FightActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FightActions @Fight => new FightActions(this);

    // Base
    private readonly InputActionMap m_Base;
    private List<IBaseActions> m_BaseActionsCallbackInterfaces = new List<IBaseActions>();
    private readonly InputAction m_Base_MousePosition;
    public struct BaseActions
    {
        private @PlayerInputAction m_Wrapper;
        public BaseActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_Base_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Base; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseActions set) { return set.Get(); }
        public void AddCallbacks(IBaseActions instance)
        {
            if (instance == null || m_Wrapper.m_BaseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BaseActionsCallbackInterfaces.Add(instance);
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
        }

        private void UnregisterCallbacks(IBaseActions instance)
        {
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
        }

        public void RemoveCallbacks(IBaseActions instance)
        {
            if (m_Wrapper.m_BaseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBaseActions instance)
        {
            foreach (var item in m_Wrapper.m_BaseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BaseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BaseActions @Base => new BaseActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnInputDirections(InputAction.CallbackContext context);
        void OnSpacePressed(InputAction.CallbackContext context);
        void OnControlPressed(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IFightActions
    {
        void OnLeftMouseButtonPressed(InputAction.CallbackContext context);
        void OnRightMouseButtonPressed(InputAction.CallbackContext context);
    }
    public interface IBaseActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
