using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AxisSelector
{
    private UnityAction onXAxisSelected;
    private UnityAction onYAxisSelected;
    private UnityAction onZAxisSelected;

    public AxisSelector(UnityAction OnXAxisSelected, UnityAction OnYAxisSelected, UnityAction OnZAxisSelected)
    {
        onXAxisSelected = OnXAxisSelected;
        onYAxisSelected = OnYAxisSelected;
        onZAxisSelected = OnZAxisSelected;
    }

    public void SelectAxisAndInvoke(AxisVector3 axis)
    {
        switch(axis)
        {
            case AxisVector3.X:
                onXAxisSelected.Invoke();
                break;

            case AxisVector3.Y:
                onYAxisSelected.Invoke();
                break;

            case AxisVector3.Z:
                onZAxisSelected.Invoke();
                break;
        }
    }
}
