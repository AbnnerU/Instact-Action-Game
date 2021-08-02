using UnityEngine;

public class AmplifyDamageArea : MonoBehaviour
{
    [Range(0, 100)]
    [SerializeField] private int percentageOfDamageAmplify;

    [SerializeField] private float durationOfAmplifier;

    [SerializeField] private bool continuosAmplifier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("enter");
        collision.gameObject.GetComponent<NegativeEfects>()?.DamageAmplifier(percentageOfDamageAmplify, durationOfAmplifier, continuosAmplifier);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (continuosAmplifier)
        {
            collision.gameObject.GetComponent<NegativeEfects>()?.Slow(0, 0, continuosAmplifier);
        }
    }
}
