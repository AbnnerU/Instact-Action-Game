
using UnityEngine;

public class FireArea : MonoBehaviour
{
    [SerializeField] private int totalDamage;
    [SerializeField] private int burnDuration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<NegativeEfects>()?.Burn(totalDamage, burnDuration);
    }

}
