using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float followSpeed;

    private Vector3 velocity = Vector3.zero;


    private void Update()
    {
        if (target != null)
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(target.position.x, transform.position.y, -10), ref velocity, followSpeed);
    }
         
}
