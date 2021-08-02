using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;

    [SerializeField] private Collider2D atackCollider;

    [SerializeField] private float defaltMoveDirectionDistance;

    public event Action<bool> OnAtackEvent;

    //public event Action OnCancelAnimation;

    private float currentAtackSide;

    private bool canAtack;

    private bool stunned;

    private void OnEnable()
    {
        atackCollider.enabled = false;
        canAtack = true;
    }

    public void CallAtackEvent(float atackSide)
    {
        //print(stunned);
        if (canAtack == false || stunned==true )
        {
            return;
        }

        currentAtackSide = atackSide;

        canAtack = false;

        OnAtackEvent?.Invoke(true);

    }


    public void StartAtack()
    {
        parentObject.transform.position += new Vector3(defaltMoveDirectionDistance * currentAtackSide, 0, 0);

        parentObject.transform.localScale = new Vector3(currentAtackSide, 1, 1);

        atackCollider.enabled = true;
    }

    public  void StopAtack()
    {

        atackCollider.enabled = false;

        OnAtackEvent?.Invoke(false);

    }

    public  void CanAtack()
    {
        canAtack = true;
        OnAtackEvent?.Invoke(false);
    }

    public void CantAtack()
    {
        canAtack = false;
    }

    public void Stuned(bool setStunned)
    {
        stunned = setStunned;
    }
}
