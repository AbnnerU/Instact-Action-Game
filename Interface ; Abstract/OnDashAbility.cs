using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OnDashAbility : MonoBehaviour
{
    protected Dash dash;

    protected virtual void Start()
    {
        dash = GetComponent<Dash>();

        SetEventFuncion();
    }

    protected abstract void SetEventFuncion();
}
