using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAfterTransform : MonoBehaviour
{
    #region
    [Header("Transform - target of the rotation.")]
    [SerializeField] private ListeningTransform persecutedTransform;
    [Header("The local rotation axis of the object.")]
    [Header("")]
    [SerializeField] private AxisVector3 rotationAxisName;
    [Header("The modifier by which the rotation angle is multiplied.")]
    [Range(0,100)]
    [SerializeField] private float rotationSpeed;

    private AxisSelector axisSelector;
    #endregion

    #region
    private void Awake ()
    {
        persecutedTransform.OnLocalRotationChanged += delegate { Rotate();};
    }

    private void Start ()
    {
        Rotate();
    }

    private void Rotate()
    {
        Quaternion targetGlobalRotation = persecutedTransform.GlobalQuaternion;
        transform.rotation = ReturnTargetAxisRotation(targetGlobalRotation.eulerAngles);
    }

    private Quaternion ReturnTargetAxisRotation(Vector3 targetRotation)
    {
        Vector3 targetGlobalRotation = Vector3.zero;
        axisSelector = new AxisSelector(delegate { targetGlobalRotation = new Vector3(targetRotation.x , 0f,0f); },
                                        delegate { targetGlobalRotation = new Vector3(0f, targetRotation.y, 0f); },
                                        delegate { targetGlobalRotation = new Vector3(0f, 0f, targetRotation.z); });
        axisSelector.SelectAxisAndInvoke(rotationAxisName);
        return Quaternion.Euler(targetGlobalRotation.x, targetRotation.y, targetRotation.z);
    }
    #endregion
}
