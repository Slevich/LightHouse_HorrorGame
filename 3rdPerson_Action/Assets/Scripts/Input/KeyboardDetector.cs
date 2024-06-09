using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public static class KeyboardDetector
{
    #region Fields
    private static UnityAction inputDirectionIsZero = delegate {; };
    private static UnityAction inputDirectionIsNotZero = delegate {; };

    private static Vector2 movementInputDirection = Vector2.zero;
    private static PlayerInputAction inputAction;
    #endregion

    #region Properties
    private static Vector2 WASDInputDirection
    {
        get
        {
            return movementInputDirection;
        }
        set
        {
            if (value == Vector2.zero && movementInputDirection != Vector2.zero)
            {
                inputDirectionIsZero();
            }
            else
            {
                inputDirectionIsNotZero();
            }

            movementInputDirection = value;
        }
    }

    public static UnityAction MovementInputBecomeZero { get { return inputDirectionIsZero; } set { inputDirectionIsZero = value; } }
    public static UnityAction MovementInputBecomeNotZero { get { return inputDirectionIsNotZero; } set { inputDirectionIsNotZero = value; } }
    #endregion

    #region Methods
    public static void SetInputActionReference(PlayerInputAction PlayerInputAction)
    {
        inputAction = PlayerInputAction;
    }

    public static Vector2 GetWASDInputDirections()
    {
        if (inputAction == null) return Vector2.zero;

        WASDInputDirection = inputAction.Movement.InputDirections.ReadValue<Vector2>();
        return WASDInputDirection;
    }

    public static void AddListenersToShiftPressedState(Action<InputAction.CallbackContext> ShiftStartedAction, Action<InputAction.CallbackContext> ShiftCanceledAction)
    {
        if (inputAction == null) return;

        inputAction.Movement.Shift.started += ShiftStartedAction;
        inputAction.Movement.Shift.canceled += ShiftCanceledAction;
    }


    #endregion
}
