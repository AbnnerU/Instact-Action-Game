using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageble 
{
    void TakeDamage(int damageValue);
}

public interface IHaveHealth
{  
    int MaxHealt { get;  }

    int CurrentHealth { get; }
}

public interface IHittableCharacter: IDamageble, IHaveHealth
{
    event Action Ondead;

    event EventHandler OnHitEvent;
}