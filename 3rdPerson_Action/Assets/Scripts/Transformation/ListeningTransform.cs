using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListeningTransform : MonoBehaviour
{
    #region Fields
    [SerializeField] private Transform currentTransform;

    private UnityAction onLocalQuaternionChanged = delegate{;};
    private UnityAction onGlobalQuaternionChanged = delegate {; };
    #endregion

    #region Properties
    public Vector3 GlobalRotation => currentTransform.rotation.eulerAngles;
    public Vector3 LocalRotation => currentTransform.localRotation.eulerAngles;
    public Quaternion GlobalQuaternion
    {
        get { return currentTransform.rotation; }
        set { currentTransform.rotation = value; onGlobalQuaternionChanged(); }
    }

    public Quaternion LocalQuaternion
    {
        get { return currentTransform.localRotation; }
        set { currentTransform.localRotation = value; onLocalQuaternionChanged(); }
    }

    public UnityAction OnLocalQuaternionChanged { get { return onLocalQuaternionChanged; } set { onLocalQuaternionChanged = value; } }
    public UnityAction OnGlobalQuaternionChanged { get { return onGlobalQuaternionChanged; } set { onGlobalQuaternionChanged = value; } }

    public Vector3 GlobalPosition => currentTransform.position;
    public Vector3 LocalPosition => currentTransform.localPosition;
    #endregion

    #region Method
    private void Awake ()
    {
        if(!transform && TryGetComponent<Transform>(out Transform thisObjectTransform))
        {
            currentTransform = thisObjectTransform;
        }
    }
    #endregion
}
