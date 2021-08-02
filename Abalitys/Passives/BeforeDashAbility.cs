using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeDashAbility : OnDashAbility, IHavePrefab
{
    private GameObject prefab;

    protected override void SetEventFuncion()
    {
        dash.OnBeforeDash += Dash_OnBeforeDash;
    }

    private void Dash_OnBeforeDash(Vector3 position)
    {
        PoolManager.SpawnObject(prefab, position, Quaternion.identity);
    }

    public void SetPrefab(GameObject prefabToCreate)
    {
        prefab = prefabToCreate;
    }

}
