using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitProjectile : HitCount, IHavePrefab, IHaveSettableValue<float>
{
    private GameObject prefab;

    private int hitsToShootProjectile = 3;

    private int currentHitCount = 0;

    private float speedValue;

    private GameObject firePoint;

    private Ranged ranged;

    private void Start()
    {
        SetEvent();         
    }

    protected override void AtackPropreties_OnHitSomething()
    {
        currentHitCount++;
        print(currentHitCount);

        if (currentHitCount == hitsToShootProjectile)
        {
            currentHitCount = 0;

            ranged.CreateRangedObject();
        }
    }

    public void SetPrefab(GameObject prefabToCreate)
    {
        prefab = prefabToCreate;
    }

    public void SetValue(float value)
    {
        speedValue = value;

        ConfigNewScript(gameObject, prefab, speedValue);
    }

    private void ConfigNewScript(GameObject parentObject, GameObject prefabObject, float speed)
    {
        firePoint = GameObject.FindGameObjectWithTag("ProjectilesFirePoint");

        ranged = gameObject.AddComponent<Ranged>();
        ranged.SetValues(parentObject, firePoint, prefabObject, speed);
    }
}
