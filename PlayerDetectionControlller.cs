using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionControlller : MonoBehaviour
{
    [SerializeField] private BoxCollider2D detectionCollider;


    public void DisableDetection()
    {
        detectionCollider.enabled = false;
    }

    public void EnableDetection()
    {
        detectionCollider.enabled = true;
    }
}
