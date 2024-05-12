using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public static class KeyboardDetector
{
    public static Vector2 ReadWASDInputDirections(PlayerInputAction inputAction)
    {
        return inputAction.Movement.InputDirections.ReadValue<Vector2>();
    }
}
