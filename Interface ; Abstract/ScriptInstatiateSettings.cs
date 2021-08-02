using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHavePrefab
{
    void SetPrefab(GameObject prefabToCreate);  
}

public interface IHaveSettableValue<T>
{
    void SetValue(T value);
}