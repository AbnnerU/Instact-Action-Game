using UnityEngine;

public class RepulsionArea : MonoBehaviour
{
    [SerializeField] private int repulsionForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<NegativeEfects>()?.Repulsion(repulsionForce);
    }
}
