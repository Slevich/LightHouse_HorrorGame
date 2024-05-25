using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMovementBasedRotationTransform : MovementBase
{
    #region Fields
    #region Serialized
    [Space(10)]
    [Header("'InputHandler' component reference.")]
    [SerializeField] private InputHandler inputHandler;
    [Header("Main camera component reference.")]
    [SerializeField] private Camera playerCamera;
    [Header("Base axis to move player.")]
    [SerializeField] private ListeningTransform rotatingTransform;
    [Header("Forward vector axis name.")]
    [SerializeField] private AxisVector3 forwardVector = AxisVector3.Z;
    [Header("Sprint speed modifier")]
    [SerializeField] private float sprintSpeedModifier = 1.0f;
    #endregion
    #region NonSerialized
    private float movementCurrentSpeed = 0f;
    #endregion

    #endregion

    #region Properties
    private Vector2 inputMovementDirection => inputHandler.BaseMovementButtonsInputDirection;
    #endregion

    #region Methods
    void Awake ()
    {
        if (!inputHandler) Debug.LogError("InputHanlder reference not set to player movement component!");
        if (!playerCamera) Debug.LogError("Camera reference not set to player movement component!");
        if(!rotatingTransform)
        {
            Debug.LogError("Player transform reference not set to player movement component!"); ;
        }

        //rotatingTransform.OnGlobalQuaternionChanged += delegate { RecalculateMovementDirections(); };
    }

    private void FixedUpdate()
    {
        if (inputMovementDirection == Vector2.zero) return;

        movementCurrentSpeed = movementBaseSpeed * sprintSpeedModifier;
        movementTarget = CalculateTargetPoint(inputMovementDirection);
        movementTarget.y = transform.position.y;

        Vector3 targetPosition = Vector3.Lerp(transform.position, movementTarget, Time.fixedDeltaTime);
        if (transform.position != targetPosition)
        {
            transform.position = targetPosition;
        }
    }

    private Vector3 CalculateTargetPoint(Vector2 inputDirection)
    {
        //(Vector3 X, Vector3 Y, Vector3 Z) rotatingTransformWorldDirections = GetRotatingAxesDirections();
        Vector3 targetPosition = rotatingTransform.LocalPosition;
        Vector3 horizontalRightLeftDirection = ReturnTargetPoint(targetPosition, Vector3.right) * inputDirection.x;
        Vector3 horizontalForwardBackDirection = ReturnTargetPoint(targetPosition, Vector3.forward) * inputDirection.y;
        Vector3 rotatingTransformDirections = (horizontalRightLeftDirection + horizontalForwardBackDirection) * movementCurrentSpeed;
        Vector3 directionPoint = rotatingTransformDirections;
        return rotatingTransform.transform.TransformPoint(directionPoint);
    }

    private Vector3 ReturnTargetPoint(Vector3 currentPosition, Vector3 localDirection)
    {
        return currentPosition + localDirection;
    }

    void OnDrawGizmos ()
    {
        Color color;
        color = Color.green;
        // local up
        DrawHelperAtCenter(this.transform.up, color, 2f);

        color.g -= 0.5f;
        // global up
        DrawHelperAtCenter(Vector3.up, color, 1f);

        color = Color.blue;
        // local forward
        DrawHelperAtCenter(this.transform.forward, color, 2f);

        color.b -= 0.5f;
        // global forward
        DrawHelperAtCenter(Vector3.forward, color, 1f);

        color = Color.red;
        // local right
        DrawHelperAtCenter(this.transform.right, color, 2f);

        color.r -= 0.5f;
        // global right
        DrawHelperAtCenter(Vector3.right, color, 1f);
    }

    private void DrawHelperAtCenter (
                       Vector3 direction, Color color, float scale)
    {
        Gizmos.color = color;
        Vector3 destination = transform.position + direction * scale;
        Gizmos.DrawLine(transform.position, destination);
    }
    #endregion
}
