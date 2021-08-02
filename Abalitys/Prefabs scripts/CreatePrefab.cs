using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{
    [SerializeField] private AbilityTimer abilityTimer;

    [SerializeField] private GameObject prefab;

    [SerializeField] private bool destroyAfterCreate;

    private void Start()
    {
        abilityTimer.OnTimerEnd += AbilityTimer_OnTimerEnd;
    }

    private void AbilityTimer_OnTimerEnd()
    {
        PoolManager.SpawnObject(prefab, transform.position, Quaternion.identity);

        if (destroyAfterCreate)
            PoolManager.ReleaseObject(gameObject);
    }
}
