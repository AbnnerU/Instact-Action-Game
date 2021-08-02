using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideWeapon : MonoBehaviour
{
    [SerializeField] private Weapon weaponObject;

    [SerializeField] private BoxCollider2D atackCollider;

    [SerializeField] private AtackPropreties atackPropreties;

    private Animator anim;

  
    private void Awake()
    {
        anim = GetComponent<Animator>();

        //propreties = GetComponent<AtackPropreties>();

        anim.runtimeAnimatorController = weaponObject.animatorOverride;

        atackPropreties.SetAtackDamage(weaponObject.damage);

        atackCollider.size = new Vector2(weaponObject.atackRange, 1);


    }
}
