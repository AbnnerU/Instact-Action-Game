using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] private float dashDistance;

    public Action<Vector3> OnBeforeDash;

    public Action<Vector3> OnAfterDash;

     public void StartDash(float direction)
    {
        OnBeforeDash?.Invoke(transform.position);
        //print("Antes: " + transform.position);

        transform.position += Vector3.right * dashDistance * Mathf.Sign(direction);

        transform.localScale = new Vector3(Mathf.Sign(direction), 1, 1);

        OnAfterDash?.Invoke(transform.position);

        //print("Depois: " + transform.position);
    }
}
