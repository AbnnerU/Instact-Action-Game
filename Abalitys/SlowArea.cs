
using UnityEngine;

public class SlowArea : MonoBehaviour
{
    [Range(0,100)]
    [SerializeField] private int percentageOfSlow;

    [SerializeField] private float durationOfSlow;

    [SerializeField] private bool continuosSlow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("enter");
        collision.gameObject.GetComponent<NegativeEfects>()?.Slow(percentageOfSlow, durationOfSlow, continuosSlow);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (continuosSlow)
        {
            collision.gameObject.GetComponent<NegativeEfects>()?.Slow(0, 0, continuosSlow);
        }
    }
}
