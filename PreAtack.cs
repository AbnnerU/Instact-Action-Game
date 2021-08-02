using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PreAtack : MonoBehaviour
{

    [SerializeField] private Animator anim;

    public void StartPreAtack()
    {
        anim.Play("Exclamation Pop Up", 0, 0);

    }
}
