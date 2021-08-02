using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    [SerializeField] private GameObject childObject;
    [SerializeField] private Text textObject;
    [SerializeField] private Animator anim;


    private void OnEnable()
    {
        anim.Play("Pop Up Damage", 0, 0);
    }
  

    public void ChangeText( int damage, Color color, int fontSize,/* int layerOrder*/ float positionX, float positonY)
    {
        textObject.color = color;

        textObject.fontSize = fontSize;

        textObject.text = damage.ToString();

        Vector3 newPosition = new Vector3(positionX, positonY, 0);

        childObject.transform.localPosition = Vector3.zero;

        childObject.transform.localPosition += newPosition;

    }

    public void ReleaseObject()
    {
        PoolManager.ReleaseObject(gameObject);
    }
}
