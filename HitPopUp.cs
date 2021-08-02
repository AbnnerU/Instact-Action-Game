using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUpPrefab;

    [SerializeField] private int valueToRandomizePositionX;

    [SerializeField] private int valueToRandomizePositionY;

    [SerializeField] private int DamageValueToMaxFontSize;

    [SerializeField] private int minFontSize;
    [SerializeField] private int maxFontSize;


    public void CreatePopUp(GameObject reference, int value)
    {

        GameObject obj = PoolManager.SpawnObject(popUpPrefab);

        obj.transform.SetParent(gameObject.transform, false);

       //print(Camera.main.WorldToScreenPoint(position.transform.position));


        obj.transform.position = Camera.main.WorldToScreenPoint(reference.transform.position);

        int currentFontSize;

        int positionRandomizeX = Random.Range(-valueToRandomizePositionX, valueToRandomizePositionX);
        int positionRandomizeY = Random.Range(-valueToRandomizePositionY, valueToRandomizePositionY);


        if (value > DamageValueToMaxFontSize)
        {
            currentFontSize = maxFontSize;
        }
        else
        {
            currentFontSize = minFontSize;
        }

        obj.GetComponent<Hit>().ChangeText(value, Color.red, currentFontSize, positionRandomizeX, positionRandomizeY);

    }
}
