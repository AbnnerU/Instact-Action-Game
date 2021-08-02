using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterDashAbility : OnDashAbility, IHavePrefab
{
    private GameObject prefab;

    protected override void SetEventFuncion()
    {
        dash.OnAfterDash += Dash_OnAfterDash;
    }

    private void Dash_OnAfterDash(Vector3 position)
    {
        PoolManager.SpawnObject(prefab, position, Quaternion.identity);
    }

    public void SetPrefab(GameObject prefabToCreate)
    {
        prefab = prefabToCreate;
    }
}
