using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    [SerializeField] protected Atack atackEvent;

    [SerializeField] protected float moveSpeed;

    //protected Rigidbody2D rb;

    protected IHittableCharacter character;

    protected CurrentScale currentScale;

    protected GameObject target;

    protected bool canMove;

    protected bool stunned;

    protected float defaltMoveSpeed;



    protected virtual void Start()
    {        
        currentScale = GetComponent<CurrentScale>();
        //print(defaltMoveSpeed);
        character = GetComponent<IHittableCharacter>();

        defaltMoveSpeed = moveSpeed;

        character.OnHitEvent += Character_OnHitEvent;

        atackEvent.OnAtackEvent += AtackTrigger_OnAtackEvent;

    }

    protected virtual void OnEnable()
    {
        stunned = false;

        canMove = true;

        target = GameObject.FindGameObjectWithTag("Player");
       
        //rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void OnDisable()
    {
        moveSpeed = defaltMoveSpeed;
    }

    protected virtual void Update()
    {
        if (target != null)
        {
            if (canMove && stunned == false)
            {
                Vector2 newPlayerPosition = target.transform.position;

                Vector2 direction = target.transform.position - transform.position;

                float sign = Mathf.Sign(direction.x);

                if (currentScale.GetScaleX() != sign)
                {
                    currentScale.SetScaleX(sign);

                    transform.localScale = new Vector3(sign, 1, 1);
                }


                transform.position = Vector2.MoveTowards(transform.position, new Vector2(newPlayerPosition.x, transform.position.y), moveSpeed * Time.deltaTime);
            }
        }
    }

    protected virtual void AtackTrigger_OnAtackEvent(bool atacking)
    {
        canMove = !atacking;
    }

    protected virtual void Character_OnHitEvent(object sender, EventArgs e)
    {
        canMove = false;
    }



}
