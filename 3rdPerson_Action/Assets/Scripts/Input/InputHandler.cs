using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    #region Fields
    private PlayerInputAction inputAction;

    public Vector2 InputDirectionsAxes => inputAction.Movement.InputDirections.ReadValue<Vector2>();
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
        AddListenersToInputActions();
    }

    private void Update ()
    {
        Vector2 inputDirection = inputAction.Movement.InputDirections.ReadValue<Vector2>();
        Debug.Log($"Input 2D Vector: X: {inputDirection.x} Y: {inputDirection.y}");
    }

    public void AddListenersToInputActions()
    {
        
    }
    #endregion
}
