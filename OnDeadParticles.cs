using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeadParticles : MonoBehaviour
{
    [SerializeField] private GameObject particle;

    private IHittableCharacter hittableCharacter;


    private void Start()
    {
        hittableCharacter = GetComponent<IHittableCharacter>();

        hittableCharacter.Ondead += HittableCharacter_Ondead;
    }

    private void HittableCharacter_Ondead()
    {
        Instantiate(particle,transform.position,Quaternion.identity);

        Destroy(gameObject);
    }
}
