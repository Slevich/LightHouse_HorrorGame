using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class RotationByMouseMovement : MonoBehaviour
{
    #region Fields
    [SerializeField] private ListeningTransform rotatingTransform;
    [SerializeField] private InputHandler readingMouseInputAxis;
    [SerializeField] private AxisVector3 guideAxis = AxisVector3.Z;
    [Range(0,100f)]
    [SerializeField] private float rotationSpeedMultiplier = 1f;

    private Vector2 mouseDelta;
    private Vector3 targetRotation = Vector3.zero;
    private float deltaLength;
    private float horizontalAxisRotationLimit = 88f;
    #endregion

    #region Methods
    private void Awake ()
    {
        rotatingTransform.GlobalQuaternion = Quaternion.Euler(0, 0, 0f);
        readingMouseInputAxis.AddListenersToMouseMovement(delegate { rotatingTransform.LocalQuaternion = CalculateLocalRotation(); });
    }

    private Quaternion CalculateLocalRotation()
    {
        deltaLength = MouseDetector.MouseDeltaVectorLenght;
        mouseDelta = MouseDetector.MouseDeltaClamped;
        Quaternion firstAxisTargetRotation = Quaternion.identity;
        Quaternion secondAxisTargetRotation = Quaternion.identity;
        Vector3 firstRotationAxis = Vector3.zero;
        Vector3 secondRotationAxis = Vector3.zero;
        float firstAxisTargetAngle = 0f;
        float secondAxisTargetAngle = 0f;

        switch(guideAxis)
        {
            case AxisVector3.X:
                targetRotation.y += mouseDelta.x * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.z += mouseDelta.y * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.z = Mathf.Clamp(targetRotation.z, -horizontalAxisRotationLimit, horizontalAxisRotationLimit);
                firstAxisTargetAngle = targetRotation.y;
                secondAxisTargetAngle = targetRotation.z;
                firstRotationAxis = Vector3.up;
                secondRotationAxis = Vector3.forward;
                break;
            case AxisVector3.Y:
                targetRotation.z += mouseDelta.x * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.x += mouseDelta.y * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.x = Mathf.Clamp(targetRotation.x, -horizontalAxisRotationLimit, horizontalAxisRotationLimit);
                firstAxisTargetAngle = targetRotation.z;
                secondAxisTargetAngle = targetRotation.x;
                firstRotationAxis = Vector3.down;
                secondRotationAxis = Vector3.right;
                break;
            case AxisVector3.Z:
                targetRotation.x += mouseDelta.x * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.y += mouseDelta.y * rotationSpeedMultiplier * Time.unscaledDeltaTime * deltaLength;
                targetRotation.y = Mathf.Clamp(targetRotation.y, -horizontalAxisRotationLimit, horizontalAxisRotationLimit);
                firstAxisTargetAngle = targetRotation.x;
                secondAxisTargetAngle = targetRotation.y;
                firstRotationAxis = Vector3.up;
                secondRotationAxis = Vector3.left;
                break;
        }

        firstAxisTargetRotation = Quaternion.AngleAxis(firstAxisTargetAngle, firstRotationAxis);
        secondAxisTargetRotation = Quaternion.AngleAxis(secondAxisTargetAngle, secondRotationAxis);
        Quaternion localRotation = firstAxisTargetRotation * secondAxisTargetRotation;
        return localRotation;
    }
    #endregion
}
