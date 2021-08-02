using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HitCount : MonoBehaviour
{
    protected AtackPropreties atackPropreties;

    protected virtual void SetEvent()
    {
        atackPropreties = GetComponentInChildren<AtackPropreties>();

        atackPropreties.OnHitSomething += AtackPropreties_OnHitSomething;
    }

    protected abstract void AtackPropreties_OnHitSomething();
    
}
