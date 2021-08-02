using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    [SerializeField] private float retreatMoveDistance;

    private IHittableCharacter character;

    private float scaleX;

    private void Start()
    {
        character = GetComponent<IHittableCharacter>();

        character.OnHitEvent += Health_OnHitEvent;
    }


    private void Health_OnHitEvent(object sender, System.EventArgs e)
    {
        scaleX = transform.localScale.x;

        //print(retreatMoveDistance * scaleX);
        transform.position -= new Vector3(retreatMoveDistance * scaleX, 0, 0);
    }
}
