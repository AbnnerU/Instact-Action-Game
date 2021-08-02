using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private CurrentScale currentScale;
    [SerializeField] private Atack atackScript;


    private float scaleX;
    //[SerializeField] private BoxCollider2D colllider; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.GetComponent<PlayerHealth>() != null)
        {
            scaleX = currentScale.GetScaleX();
            //print(scaleX);
            atackScript.CallAtackEvent(scaleX);
        }
         
    }


    //public void DisableDetection()
    //{
    //    colllider.enabled = false;
    //}

    //public void EnableDetection()
    //{
    //    colllider.enabled = true;
    //}
}
