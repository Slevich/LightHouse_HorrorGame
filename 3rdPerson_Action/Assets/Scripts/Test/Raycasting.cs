using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Raycasting : MonoBehaviour
{
    #region Fields
    [Header("Point to cast ray (transform).")]
    [SerializeField] private Transform raycastOriginTransform;
    [Space(20)]
    [Header("________________________________________________")]
    [Header("Length of the ray (float).")]
    [Range(0,50)]
    [SerializeField] private float rayLength = 20;
    [Header("Direction of the ray (enum value).")]
    [SerializeField] private RayAxis rayDirectionAxis = RayAxis.Z;
    [Header("Raycasted layers (layer mask).")]
    [SerializeField] private LayerMask raycastedLayers;
    [Header("Color of the ray (Color).")]
    [SerializeField] private Color rayColor = Color.yellow;

    private Vector3 startPoint;
    private Vector3 endPoint;
    private Vector3 raycastDirection;

    private UnityAction raycastAction;
    #endregion

    #region Enums
    enum RayAxis
    {
        X, Y, Z
    }
    #endregion

    #region Methods
    private void Awake ()
    {
        if (!raycastOriginTransform) raycastOriginTransform = GetComponent<Transform>();
    }

    private void Update ()
    {
        Raycast();
    }

    private void Raycast()
    {
        startPoint = raycastOriginTransform.position;
        raycastDirection = GetRaycastDirection(out Vector3 raycastEndPoint);
        endPoint = raycastEndPoint;

        RaycastHit[] hits = Physics.RaycastAll(startPoint, raycastDirection, rayLength, raycastedLayers);
        foreach (RaycastHit hit in hits)
        {
            raycastAction = delegate { Debug.Log(hit.collider.gameObject.name); ; };
            raycastAction?.Invoke();
        }
    }

    private Vector3 GetRaycastDirection(out Vector3 raycastEndPoint)
    {
        Vector3 directionByAxis = Vector3.zero;

        switch (rayDirectionAxis)
        {
            case RayAxis.X:
                directionByAxis = Vector3.right;
                break;

            case RayAxis.Y:
                directionByAxis = Vector3.up;
                break;

            case RayAxis.Z:
                directionByAxis = Vector3.forward;
                break;
        }

        Vector3 directionWorldSpace = raycastOriginTransform.TransformDirection(directionByAxis);
        raycastEndPoint = startPoint + (directionWorldSpace * rayLength);

        return directionWorldSpace;
    }

    private void OnDrawGizmos ()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawLine(startPoint, endPoint);
    }
    #endregion
}
