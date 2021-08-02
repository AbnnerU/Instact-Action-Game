using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHittableCharacter
{
    [SerializeField] private int maxHealt;

    private int currentHealth;

    public int MaxHealt { get { return maxHealt; } }

    public int CurrentHealth { get { return currentHealth; } }

    public event EventHandler OnHitEvent;

    public event Action Ondead;

    public void TakeDamage(int damageValue)
    {
        Ondead?.Invoke();
    }
}
