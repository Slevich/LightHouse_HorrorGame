using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MovementBase
{
    #region Fields
    #region Serialized
    [Space(10)]
    [Header("'InputHandler' component reference.")]
    [SerializeField] private InputHandler inputHandler;
    [Header("Main camera component reference.")]
    [SerializeField] private Camera playerCamera;
    [Header("Move player transform component reference.")]
    [SerializeField] private Transform playerTransform;
    #endregion
    #region NonSerialized

    #endregion

    #endregion

    #region Properties
    private Vector3 cameraGlobalPosition => playerCamera ? playerCamera.transform.position : Vector3.zero;
    private Vector3 playerGlobalPosition => playerTransform ? playerTransform.position : Vector3.zero; 
    #endregion

    #region Methods
    // Start is called before the first frame update
    void Awake ()
    {
        if (!inputHandler) Debug.LogError("InputHanlder reference not set to player movement component!");
        if (!playerCamera) Debug.LogError("Camera reference not set to player movement component!");
        if(!playerTransform)
        {
            if (TryGetComponent(out Transform thisTransform)) playerTransform = thisTransform;
            else Debug.LogError("Player transform reference not set to player movement component!"); ;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementTarget = CalculateMovementDirection();
        playerTransform.position = GetChangedMovementPosition(movementTarget);
    }

    private Vector3 GetChangedMovementPosition(Vector3 movementTarget)
    {
        return Vector3.Lerp(playerGlobalPosition, playerGlobalPosition + movementTarget, movementSpeed * Time.unscaledDeltaTime);
    }

    protected override Vector3 CalculateMovementDirection()
    {
        Vector2 directionAxes = Vector2.zero /*inputHandler.InputDirectionsAxes*/;
        Vector3 directionPoint = new Vector3(cameraGlobalPosition.x + directionAxes.x, cameraGlobalPosition.y + directionAxes.y, cameraGlobalPosition.z);
        return directionPoint;
    }

    protected override Vector3 CalculateRotationDirection ()
    {
        return Vector3.zero;
    }
    #endregion
}
