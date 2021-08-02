using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private Atack atackEvent;

    private IHittableCharacter character;

    private Animator anim;

    private void Start()
    {
        //events = GetComponent<PlayerAtack>();
        character = GetComponentInParent<IHittableCharacter>();

        anim = GetComponent<Animator>();

        atackEvent.OnAtackEvent += AtackTrigger_OnAtackEvent;

        character.OnHitEvent += Character_OnHitEvent;

    }

    private void Character_OnHitEvent(object sender, System.EventArgs e)
    {
        anim.Play("Hit", 0, 0);
    }

    private void AtackTrigger_OnAtackEvent(bool atacking)
    {
        //print(atacking);
        anim.SetBool("Atacking", atacking);

    }

   


}
