
using UnityEngine;

public class StunArea : MonoBehaviour
{
    [SerializeField] private float stunTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<NegativeEfects>()?.Stun(stunTime);
    }
}
