using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Ablity",menuName = "AbilitySettings")]
public class Ability : ScriptableObject
{

    [Header("On menu attributes")]

    public string abilityName;

    [TextArea]

    public string description;

    public Sprite abilityIcon;

    [Header("On game attributes")]

    public float RechargeTime=4;

    public bool createAnObject;

    public bool addScriptToplayer;

    public float settableValue;

    public GameObject objectPrefab;

    public Vector3 objectPrefabPosition;

    public string scriptName;

}
