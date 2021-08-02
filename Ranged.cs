using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;

    [SerializeField] private GameObject firePoint;

    [SerializeField] private GameObject prefab;

    [SerializeField] private float projectileSpeed;

    
    public void CreateRangedObject()
    {        
        GameObject obj = PoolManager.SpawnObject(prefab, firePoint.transform.position, Quaternion.identity);
    
        obj.GetComponent<Rigidbody2D>().AddForce(firePoint.transform.right * projectileSpeed * parentObject.transform.localScale.x,ForceMode2D.Impulse);

    }

    public void SetValues(GameObject parentObject, GameObject firePoint, GameObject prefab, float projectileSpeed)
    {
        this.parentObject = parentObject;
        this.firePoint = firePoint;
        this.prefab = prefab;
        this.projectileSpeed = projectileSpeed;
    }
}
