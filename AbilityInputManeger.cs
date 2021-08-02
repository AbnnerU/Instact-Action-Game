using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityInputManeger : MonoBehaviour
{
    [SerializeField] private Ability passive;

    [SerializeField] private Ability ability1;
    [SerializeField] private Ability ability2;

    public void StartAbility1()
    {
        if (ability1.createAnObject)
        {
            PoolManager.SpawnObject(ability1.objectPrefab,transform.position + ability1.objectPrefabPosition,Quaternion.identity);
        }
    }

    public void StartAbility2()
    {
        if (ability1.createAnObject)
        {
            PoolManager.SpawnObject(ability2.objectPrefab, transform.position + ability2.objectPrefabPosition, Quaternion.identity);
        }
    }

    public void ConfigNewScripts()
    {
        if (passive.addScriptToplayer)
        {
            string name = passive.scriptName;
            Type mytype = Type.GetType(name);

            gameObject.AddComponent(mytype);

            gameObject.GetComponent<IHavePrefab>()?.SetPrefab(passive.objectPrefab);

            gameObject.GetComponent<IHaveSettableValue<float>>()?.SetValue(passive.settableValue);
        }

        if (ability1.addScriptToplayer)
        {
            string name = ability1.scriptName;
            Type mytype = Type.GetType(name);

            gameObject.AddComponent(mytype);

            gameObject.GetComponent<IHavePrefab>()?.SetPrefab(ability1.objectPrefab);

            gameObject.GetComponent<IHaveSettableValue<float>>()?.SetValue(ability1.settableValue);
        }

        if (ability2.addScriptToplayer)
        {
            string name = ability2.scriptName;
            Type mytype = Type.GetType(name);

            gameObject.AddComponent(mytype);

            gameObject.GetComponent<IHavePrefab>()?.SetPrefab(ability2.objectPrefab);

            gameObject.GetComponent<IHaveSettableValue<float>>()?.SetValue(ability2.settableValue);
        }
    }

    public void SetAbilities(Ability passive, Ability ability1, Ability ability2)
    {
        this.passive = passive;
        this.ability1 = ability1;
        this.ability2 = ability2;
    }
}
