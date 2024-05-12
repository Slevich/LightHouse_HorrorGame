using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListeningTransform : MonoBehaviour
{
    #region Fields
    [SerializeField] private Transform currentTransform;

    private UnityAction onLocalRotationChanged = delegate{;};
    private UnityAction onGlobalRotationChanged = delegate {; };
    #endregion

    #region Properties
    public Vector3 GlobalRotation => currentTransform.rotation.eulerAngles;
    public Vector3 LocalRotation => currentTransform.localRotation.eulerAngles;
    public Quaternion GlobalQuaternion
    {
        get { return currentTransform.rotation; }
        set { currentTransform.rotation = value; onGlobalRotationChanged(); }
    }

    public Quaternion LocalQuaternion
    {
        get { return currentTransform.localRotation; }
        set { currentTransform.localRotation = value; onLocalRotationChanged(); }
    }

    public Vector3 GlobalPosition => currentTransform.position;
    public Vector3 LocalPosition => currentTransform.localPosition;
    public UnityAction OnLocalRotationChanged { get { return onLocalRotationChanged; } set { onLocalRotationChanged = value; } }
    #endregion

    #region Methods
    private void Awake ()
    {
        if(!transform && TryGetComponent<Transform>(out Transform thisObjectTransform))
        {
            currentTransform = thisObjectTransform;
        }
    }
    #endregion
}
