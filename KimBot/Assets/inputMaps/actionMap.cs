// GENERATED AUTOMATICALLY FROM 'Assets/inputMaps/actionMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ActionMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ActionMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""actionMap"",
    ""maps"": [
        {
            ""name"": ""kim"",
            ""id"": ""95080e4f-a2cd-4081-9773-3ea83497cbce"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""5d737e34-5c41-4ba4-94d1-edd76f46216c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveVector"",
                    ""type"": ""Value"",
                    ""id"": ""8332b78b-692e-476f-b102-99b6c23f0f6a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveR"",
                    ""type"": ""Button"",
                    ""id"": ""8f347379-70dd-404e-8799-407fd5929f81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveL"",
                    ""type"": ""Button"",
                    ""id"": ""1d0131ba-10a0-48b9-a64f-725caff2a15b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""checkRotation"",
                    ""type"": ""Button"",
                    ""id"": ""d1ceb013-0a83-49d8-82fb-d182e0be9b2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightVertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2b13e555-39f9-47cd-8a59-4c811381a2ed"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftVertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f4b6b3fd-3864-4e61-83c4-bd4d1821a388"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""6b44a7b7-96ad-4e3e-be2b-89015ea6828a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""c3b94f00-f8d4-4e82-a9ba-a1cd6f1d4ce6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d91db1b-79da-423d-b1b0-e3491caa8fe3"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""24e5d3e4-54ac-4022-a426-bf8da9a8bb6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8cac25d3-4c13-403f-93e0-8fed6cdb13f7"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42fb4659-54d8-4a5c-94e7-6190918796f2"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aaf11a60-af63-414b-901e-76ca0c9e3c29"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""471e11d3-4331-4575-aeac-4776003a7b56"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a55bdcb-8c75-48ca-a009-c755a00b5151"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""checkRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""316dc8cd-86cf-4a74-82cc-68d96e92dd99"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""42bddc78-984c-4b31-ba70-648e96cfdc3f"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""42d36f5a-76cc-4192-811e-8f158aee74b4"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""b77e5f19-d515-4764-800f-de66f22d0b11"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""32f9de22-14f4-4fb6-b200-2cb2e5a58d5d"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3bb7639d-b928-4d79-9ac9-04c8580a7bc9"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftV"",
                    ""id"": ""39db8024-fcd6-4e99-b272-9623d0c6f6a0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4c39d075-c8ae-4b0e-adac-2632d43e6ce0"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b58a58f2-868f-4cc2-8263-ae94bacb69c9"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftH"",
                    ""id"": ""f421d38d-c53b-4a2f-8be8-5416fcc4afb8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dc371c25-2f8f-4a88-992b-24fc94d1bda8"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d21dfc51-4d36-41d3-afa2-097e78850608"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // kim
        m_kim = asset.FindActionMap("kim", throwIfNotFound: true);
        m_kim_jump = m_kim.FindAction("jump", throwIfNotFound: true);
        m_kim_moveVector = m_kim.FindAction("moveVector", throwIfNotFound: true);
        m_kim_moveR = m_kim.FindAction("moveR", throwIfNotFound: true);
        m_kim_MoveL = m_kim.FindAction("MoveL", throwIfNotFound: true);
        m_kim_checkRotation = m_kim.FindAction("checkRotation", throwIfNotFound: true);
        m_kim_RightVertical = m_kim.FindAction("RightVertical", throwIfNotFound: true);
        m_kim_LeftVertical = m_kim.FindAction("LeftVertical", throwIfNotFound: true);
        m_kim_RightHorizontal = m_kim.FindAction("RightHorizontal", throwIfNotFound: true);
        m_kim_LeftHorizontal = m_kim.FindAction("LeftHorizontal", throwIfNotFound: true);
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

    // kim
    private readonly InputActionMap m_kim;
    private IKimActions m_KimActionsCallbackInterface;
    private readonly InputAction m_kim_jump;
    private readonly InputAction m_kim_moveVector;
    private readonly InputAction m_kim_moveR;
    private readonly InputAction m_kim_MoveL;
    private readonly InputAction m_kim_checkRotation;
    private readonly InputAction m_kim_RightVertical;
    private readonly InputAction m_kim_LeftVertical;
    private readonly InputAction m_kim_RightHorizontal;
    private readonly InputAction m_kim_LeftHorizontal;
    public struct KimActions
    {
        private @ActionMap m_Wrapper;
        public KimActions(@ActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_kim_jump;
        public InputAction @moveVector => m_Wrapper.m_kim_moveVector;
        public InputAction @moveR => m_Wrapper.m_kim_moveR;
        public InputAction @MoveL => m_Wrapper.m_kim_MoveL;
        public InputAction @checkRotation => m_Wrapper.m_kim_checkRotation;
        public InputAction @RightVertical => m_Wrapper.m_kim_RightVertical;
        public InputAction @LeftVertical => m_Wrapper.m_kim_LeftVertical;
        public InputAction @RightHorizontal => m_Wrapper.m_kim_RightHorizontal;
        public InputAction @LeftHorizontal => m_Wrapper.m_kim_LeftHorizontal;
        public InputActionMap Get() { return m_Wrapper.m_kim; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KimActions set) { return set.Get(); }
        public void SetCallbacks(IKimActions instance)
        {
            if (m_Wrapper.m_KimActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_KimActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnJump;
                @moveVector.started -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveVector;
                @moveVector.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveVector;
                @moveVector.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveVector;
                @moveR.started -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveR;
                @moveR.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveR;
                @moveR.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveR;
                @MoveL.started -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveL;
                @MoveL.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveL;
                @MoveL.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnMoveL;
                @checkRotation.started -= m_Wrapper.m_KimActionsCallbackInterface.OnCheckRotation;
                @checkRotation.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnCheckRotation;
                @checkRotation.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnCheckRotation;
                @RightVertical.started -= m_Wrapper.m_KimActionsCallbackInterface.OnRightVertical;
                @RightVertical.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnRightVertical;
                @RightVertical.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnRightVertical;
                @LeftVertical.started -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftVertical;
                @LeftVertical.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftVertical;
                @LeftVertical.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftVertical;
                @RightHorizontal.started -= m_Wrapper.m_KimActionsCallbackInterface.OnRightHorizontal;
                @RightHorizontal.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnRightHorizontal;
                @RightHorizontal.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnRightHorizontal;
                @LeftHorizontal.started -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftHorizontal;
                @LeftHorizontal.performed -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftHorizontal;
                @LeftHorizontal.canceled -= m_Wrapper.m_KimActionsCallbackInterface.OnLeftHorizontal;
            }
            m_Wrapper.m_KimActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @moveVector.started += instance.OnMoveVector;
                @moveVector.performed += instance.OnMoveVector;
                @moveVector.canceled += instance.OnMoveVector;
                @moveR.started += instance.OnMoveR;
                @moveR.performed += instance.OnMoveR;
                @moveR.canceled += instance.OnMoveR;
                @MoveL.started += instance.OnMoveL;
                @MoveL.performed += instance.OnMoveL;
                @MoveL.canceled += instance.OnMoveL;
                @checkRotation.started += instance.OnCheckRotation;
                @checkRotation.performed += instance.OnCheckRotation;
                @checkRotation.canceled += instance.OnCheckRotation;
                @RightVertical.started += instance.OnRightVertical;
                @RightVertical.performed += instance.OnRightVertical;
                @RightVertical.canceled += instance.OnRightVertical;
                @LeftVertical.started += instance.OnLeftVertical;
                @LeftVertical.performed += instance.OnLeftVertical;
                @LeftVertical.canceled += instance.OnLeftVertical;
                @RightHorizontal.started += instance.OnRightHorizontal;
                @RightHorizontal.performed += instance.OnRightHorizontal;
                @RightHorizontal.canceled += instance.OnRightHorizontal;
                @LeftHorizontal.started += instance.OnLeftHorizontal;
                @LeftHorizontal.performed += instance.OnLeftHorizontal;
                @LeftHorizontal.canceled += instance.OnLeftHorizontal;
            }
        }
    }
    public KimActions @kim => new KimActions(this);
    public interface IKimActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveVector(InputAction.CallbackContext context);
        void OnMoveR(InputAction.CallbackContext context);
        void OnMoveL(InputAction.CallbackContext context);
        void OnCheckRotation(InputAction.CallbackContext context);
        void OnRightVertical(InputAction.CallbackContext context);
        void OnLeftVertical(InputAction.CallbackContext context);
        void OnRightHorizontal(InputAction.CallbackContext context);
        void OnLeftHorizontal(InputAction.CallbackContext context);
    }
}
