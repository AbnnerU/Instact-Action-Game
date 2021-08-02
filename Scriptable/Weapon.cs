using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "NewWeapon")]
public class Weapon : ScriptableObject
{

    public AnimatorOverrideController animatorOverride;

    public int damage;

    public float atackRange;

}
