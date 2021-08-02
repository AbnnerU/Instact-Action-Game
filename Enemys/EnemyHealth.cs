using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, IHittableCharacter
{

    [SerializeField] private GameObject referenceToPopUpDamage;

    [SerializeField] private int maxHealt;

    [SerializeField] private Slider healtBar;

    public int MaxHealt { get { return maxHealt; } }

    public int CurrentHealth { get { return currentHealth; } }

    private int currentHealth = 100;

    public event EventHandler OnHitEvent;

    public event Action Ondead;

    private HitPopUp hitPopUp;

    private SpawnManeger spawnManeger;

    private float amplifyDamageValue;

    private void OnEnable()
    {
        hitPopUp = FindObjectOfType<HitPopUp>();

        spawnManeger = FindObjectOfType<SpawnManeger>();

        currentHealth = maxHealt;

        healtBar.maxValue = maxHealt;
        healtBar.value = maxHealt;

        
    }

    private void OnDisable()
    {
        amplifyDamageValue = 0;
    }

    public void TakeDamage(int damageValue)
    {
        int damageAmount = (int)(damageValue +(damageValue * (amplifyDamageValue / 100)));

        currentHealth -= damageAmount;

        healtBar.value = currentHealth;

        //print(referenceToPopUpDamage.transform.position);

        hitPopUp.CreatePopUp(referenceToPopUpDamage, damageAmount);

        if (currentHealth <= 0)
        {
            spawnManeger.IncreasePlayerKills();
            PoolManager.ReleaseObject(gameObject);
        }
        else
        {
            OnHitEvent?.Invoke(this, null);
        }        
    }

    public void TakeDamageWhitoutHitEvent(int damageValue)
    {
        int damageAmount = (int)(damageValue + (damageValue * (amplifyDamageValue / 100)));

        DecreaseHealt(damageAmount);
    }

    public void DecreaseHealt(int damage)
    {
        currentHealth -= damage;

        healtBar.value = currentHealth;

        hitPopUp.CreatePopUp(referenceToPopUpDamage, damage);

        if (currentHealth <= 0)
        {
            spawnManeger.IncreasePlayerKills();
            PoolManager.ReleaseObject(gameObject);
        }
    }

    public void CallOnHitEvent()
    {
        OnHitEvent?.Invoke(this, null);
    }

    public void SetDamageAmplification(float value)
    {
        amplifyDamageValue = value;
    }
}
