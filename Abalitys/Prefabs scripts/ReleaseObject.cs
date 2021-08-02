using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseObject : MonoBehaviour
{
    [SerializeField] private AbilityTimer abilityTimer;

    private void Start()
    {
        abilityTimer.OnTimerEnd += AbilityTimer_OnTimerEnd;
    }

    private void AbilityTimer_OnTimerEnd()
    {
        PoolManager.ReleaseObject(gameObject);
    }

}
