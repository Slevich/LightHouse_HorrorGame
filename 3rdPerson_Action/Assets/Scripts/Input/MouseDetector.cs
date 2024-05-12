using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class MouseDetector
{
    #region Fields
    private static Vector2 mousePreviousPosition = Vector2.zero;
    private static Vector2 mouseCurrentPosition = Vector2.zero;
    private static Vector2 mouseDeltaClamped = Vector2.zero;
    private static Vector2 mouseDelta = Vector2.zero;
    private static float mouseDeltaVectorLenght = 0f;
    public static UnityAction onMouseMovement = delegate {; };
    #endregion

    #region Properties
    public static Vector2 MouseDelta => mouseDelta;
    public static Vector2 MouseDeltaClamped => mouseDeltaClamped;
    public static float MouseDeltaVectorLenght => mouseDeltaVectorLenght;
    public static UnityAction OnMouseMovement { get { return onMouseMovement; } set { onMouseMovement = value; } }
    #endregion

    #region Methods
    public static void CalculateMouseValues(PlayerInputAction inputAction)
    {
        mouseCurrentPosition = inputAction.Base.MousePosition.ReadValue<Vector2>();
        mouseDelta = ReturnMouseDeltaPosition(mouseCurrentPosition);
        mouseDeltaClamped = ReturnMouseDeltaPositionClampled(mouseDelta);

        if(mouseDelta != Vector2.zero)
        {
            onMouseMovement();
        }
    }

    public static Vector2 ReturnMouseDeltaPosition(Vector2 mousePosition)
    {
        Vector2 delta = mouseCurrentPosition - mousePreviousPosition;
        mouseDeltaVectorLenght = Vector2.Distance(mousePreviousPosition, mouseCurrentPosition);
        mousePreviousPosition = mousePosition;
        return delta;
    }

    public static Vector2 ReturnMouseDeltaPositionClampled(Vector2 mouseDelta)
    {
        return new Vector2(Mathf.Clamp(mouseDelta.x, -1, 1), Mathf.Clamp(mouseDelta.y, -1, 1));
    }
    #endregion
}
