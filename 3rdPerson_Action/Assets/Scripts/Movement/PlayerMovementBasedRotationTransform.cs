using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Events;

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
    [SerializeField] private float sprintSpeedModifier = 1.8f;
    #endregion
    #region NonSerialized
    private float movementCurrentSpeed = 0f;
    private float sprintSpeedIncreaseModifier = 1f;
    private Coroutine currentCoroutine;
    private bool isInputVectorNotZero = false;
    private bool canRun = true;
    private float targetSpeed = 0f;
    private Vector2 inputDirection = Vector2.zero;
    private UnityAction lerpingValueAction;
    #endregion

    #endregion

    #region Properties
    public float MaxMovementSpeed => baseMovementMaxSpeed * sprintSpeedModifier;

    private float speedChangeModifier 
    { 
        get 
        { 
            if(targetSpeed == 0)
            {
                return 8f; 
            }

            return 10f / targetSpeed;
        } 
    }

    private Vector2 inputMovementDirection => inputHandler.BaseMovementButtonsInputDirection;

    private Vector2 inputModificator
    {
        get
        {
            return inputDirection;
        }
        set
        {
            if(value != Vector2.zero)
            {
                inputDirection = value;
            }
        }
    }

    private bool inputIsActive
    {
        get { return isInputVectorNotZero ; }
        set 
        { 
            if(value == true && isInputVectorNotZero == false)
            {
                StopCurrentCoroutine();
                targetSpeed = baseMovementMaxSpeed;
                currentCoroutine = StartCoroutine(LerpCurrentSpeedToValue());
            }
            else if(value == false && isInputVectorNotZero == true)
            {
                StopCurrentCoroutine();
                targetSpeed = 0f;
                currentCoroutine = StartCoroutine(LerpCurrentSpeedToValue());
            }
            isInputVectorNotZero = value; 
        }
    }

    public bool CanRun { get { return canRun; } set { canRun = value; } }
    #endregion

    #region Methods
    void Awake ()
    {
        if (!inputHandler) Debug.LogError("InputHandler reference not set to player movement component!");
        if (!playerCamera) Debug.LogError("Camera reference not set to player movement component!");
        if(!rotatingTransform)
        {
            Debug.LogError("Player transform reference not set to player movement component!"); ;
        } 
        KeyboardDetector.AddListenersToShiftPressedState(delegate 
                                                                {
                                                                    if(canRun && inputIsActive)
                                                                    {
                                                                        targetSpeed = baseMovementMaxSpeed * sprintSpeedModifier;
                                                                        sprintSpeedIncreaseModifier = sprintSpeedModifier;
                                                                        StopCurrentCoroutine();
                                                                        currentCoroutine = StartCoroutine(LerpCurrentSpeedToValue());
                                                                        Debug.Log("¡≈∆»Ã!");
                                                                    }
                                                                }, 
                                                         delegate 
                                                                {
                                                                    if(canRun)
                                                                    {
                                                                        if(inputIsActive)
                                                                        {
                                                                            targetSpeed = baseMovementMaxSpeed;
                                                                        }
                                                                        else
                                                                        {
                                                                            targetSpeed = 0f;
                                                                        }
                                                                        sprintSpeedIncreaseModifier = 1f;
                                                                        StopCurrentCoroutine();
                                                                        currentCoroutine = StartCoroutine(LerpCurrentSpeedToValue());
                                                                        Debug.Log("Œ—“¿Õ¿¬À»¬¿≈Ã—ﬂ!");
                                                                    }
                                                                });
    }

    private void FixedUpdate()
    {
        inputIsActive = inputMovementDirection != Vector2.zero;
        inputModificator = inputMovementDirection;
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        movementTarget = CalculateTargetPoint();
        movementTarget.y = transform.position.y;

        Vector3 targetPosition = Vector3.Lerp(transform.position, movementTarget, Time.fixedDeltaTime);
        if (transform.position != targetPosition)
        {
            transform.position = targetPosition;
        }
    }

    private Vector3 CalculateTargetPoint()
    {
        Vector3 targetPosition = rotatingTransform.LocalPosition;
        Vector3 horizontalRightLeftDirection = ReturnTargetPoint(targetPosition, Vector3.right) * inputModificator.x;
        Vector3 horizontalForwardBackDirection = ReturnTargetPoint(targetPosition, Vector3.forward) * inputModificator.y;
        Vector3 rotatingTransformDirections = (horizontalRightLeftDirection + horizontalForwardBackDirection) * movementCurrentSpeed;
        Vector3 directionPoint = rotatingTransformDirections;
        return rotatingTransform.transform.TransformPoint(directionPoint);
    }

    private Vector3 ReturnTargetPoint(Vector3 currentPosition, Vector3 localDirection)
    {
        return currentPosition + localDirection;
    }

    private IEnumerator LerpCurrentSpeedToValue()
    {
        (float LessValue, float GreaterValue, float DirectionModifier) values = DefineLerpDirection();

        if(values.LessValue == movementCurrentSpeed)
        {
            lerpingValueAction = delegate { values.LessValue = movementCurrentSpeed; };
        }
        else
        {
            lerpingValueAction = delegate { values.GreaterValue = movementCurrentSpeed; };
        }

        while (values.LessValue < values.GreaterValue)
        {
            float changedValue = Time.fixedDeltaTime * speedChangeModifier * sprintSpeedIncreaseModifier;
            movementCurrentSpeed += changedValue * values.DirectionModifier;
            Debug.Log($"Current speed = {movementCurrentSpeed} \nTargetSpeed = {targetSpeed}");
            lerpingValueAction();
            yield return new WaitForFixedUpdate();
        }

        movementCurrentSpeed = targetSpeed;
        currentCoroutine = null;
    }

    private (float LessValue, float GreaterValue, float DirectionModifier) DefineLerpDirection()
    {
        (float LessValue, float GreaterValue, float DirectionModifier) values = (0f,0f,0f);

        if (movementCurrentSpeed > targetSpeed)
        {
            values.LessValue = targetSpeed;
            values.GreaterValue = movementCurrentSpeed;
            values.DirectionModifier = -1f;
        }
        else if (movementCurrentSpeed < targetSpeed)
        {
            values.LessValue = movementCurrentSpeed;
            values.GreaterValue = targetSpeed;
            values.DirectionModifier = 1f;
        }

        return values;
    }

    private void StopCurrentCoroutine()
    {
        if(currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
            currentCoroutine = null;
        }
    }
    #endregion
}
