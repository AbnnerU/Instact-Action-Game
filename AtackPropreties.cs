using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackPropreties : MonoBehaviour
{
   [SerializeField] private int atackDamage=10;

    public Action OnHitSomething;

    public void SetAtackDamage(int value)
    {
        //print(value);
        atackDamage = value;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageble damageble = collision.GetComponent<IDamageble>();

        if (damageble != null)
        {
            damageble.TakeDamage(atackDamage);

            OnHitSomething?.Invoke();
        }
    }
}
