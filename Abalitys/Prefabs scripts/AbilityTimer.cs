using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityTimer : MonoBehaviour
{
    [SerializeField] private float time;

    public Action OnTimerEnd;

    private void OnEnable()
    {
        StartCoroutine(StartTimer());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(time);

        OnTimerEnd?.Invoke();

        StopCoroutine(StartTimer());
    }
}
