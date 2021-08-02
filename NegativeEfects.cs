using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeEfects : MonoBehaviour
{

    [SerializeField] private EnemyHealth enemyHealth;

    [SerializeField] private OnHit onHit;

    [SerializeField] private CurrentScale currentScale;

    [SerializeField] private Atack atack;

    private Coroutine stunCorountine;

    private Coroutine burnCorountine;

    private Coroutine slowCorountine;

    private Coroutine damageAmplifierCorountine;

    private IHaveMovementNegativeEffects movement;


    private void OnEnable()
    {
        movement = GetComponent<IHaveMovementNegativeEffects>();
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void DamageAmplifier(int damageAmplification,float damageAplifierDuration, bool continuos)
    {
        if (continuos)
        {
            enemyHealth.SetDamageAmplification(damageAmplification);
        }
        else
        {
            if (damageAmplifierCorountine != null)
                StopCoroutine(damageAmplifierCorountine);

           damageAmplifierCorountine = StartCoroutine(DamageAplifierEffect(damageAmplification, damageAplifierDuration));
        }
    }

    public void Burn(int totalDamage, int duration)
    {
        burnCorountine = StartCoroutine(BurnEffect(totalDamage, duration));
    }

    public void Slow(int slowForce, float timeOfSlow, bool continuosSlow)
    {
        if (continuosSlow)
        {
            movement.AplySlow(slowForce);
        }
        else
        {
            if (slowCorountine != null)
                StopCoroutine(slowCorountine);

            slowCorountine = StartCoroutine(SlowEffect(slowForce, timeOfSlow));
        }
    }

    public void Repulsion(float repulsionForce)
    {
        movement.AplyRepulsion(repulsionForce);
    }

    public void Stun(float stunTime)
    {
        if(stunCorountine!=null)
        StopCoroutine(stunCorountine);

        stunCorountine = StartCoroutine(StunEffect(stunTime));
    }

    IEnumerator StunEffect(float stunTime)
    {
        enemyHealth.CallOnHitEvent();

        movement.AplyStun(true);

        atack.Stuned(true);

        yield return new WaitForSeconds(stunTime);

        movement.AplyStun(false);

        atack.Stuned(false);

        StopCoroutine(stunCorountine);
    }

    IEnumerator BurnEffect(int totalDamage, int duration)
    {
        float damagePerTick = totalDamage / duration; 

        for(int i = 0; i < duration; i++)
        {
            enemyHealth.DecreaseHealt((int)damagePerTick);
            yield return new WaitForSeconds(1);
        }
        StopCoroutine(burnCorountine);
    }

    IEnumerator SlowEffect(int slowForce, float timeOfSlow)
    {
        movement.AplySlow(slowForce);

        yield return new WaitForSeconds(timeOfSlow);

        movement.AplySlow(0);

        StopCoroutine(slowCorountine);
    }

    IEnumerator DamageAplifierEffect(int damageAmplification, float amplificationTime)
    {
        enemyHealth.SetDamageAmplification(damageAmplification);

        yield return new WaitForSeconds(amplificationTime);

        enemyHealth.SetDamageAmplification(0);

        StopCoroutine(damageAmplifierCorountine);
    }
}
