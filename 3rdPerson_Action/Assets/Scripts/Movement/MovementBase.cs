using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementBase : MonoBehaviour
{
    #region Fields
    [Range(0,100)]
    [SerializeField] protected float movementSpeed = 1f;
    [Range(0, 100)]
    [SerializeField] protected float rotationSpeed = 1f;

    protected Vector3 movementDirection;
    protected Vector3 rotationDirection;
    #endregion

    #region Methods
    protected abstract Vector3 CalculateMovementDirection();
    protected abstract Vector3 CalculateRotationDirection();
    #endregion
}
