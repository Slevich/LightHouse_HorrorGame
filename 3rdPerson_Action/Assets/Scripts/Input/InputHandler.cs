using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    #region Fields
    private PlayerInputAction inputAction;

    private Vector2 mousePosition = Vector2.zero;
    private Vector2 baseMovementButtonsInputDirection = Vector2.zero;
    public Vector2 mousePositionVector => mousePosition;
    public Vector3 BaseMovementButtonsInputDirection => baseMovementButtonsInputDirection;
    #endregion

    #region Methods
    private void OnEnable ()
    {
        inputAction.Enable();
    }

    private void OnDisable ()
    {
        inputAction.Disable();
    }

    private void Awake ()
    {
        inputAction = new PlayerInputAction();
        Cursor.visible = false;
    }

    private void Update ()
    {
        MouseDetector.CalculateMouseValues(inputAction);
        baseMovementButtonsInputDirection = KeyboardDetector.ReadWASDInputDirections(inputAction);
    }

    public void AddListenersToMouseMovement(UnityAction action)
    {
        MouseDetector.OnMouseMovement += action;
    }
    #endregion
}
