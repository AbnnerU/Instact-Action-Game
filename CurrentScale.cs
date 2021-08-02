using UnityEngine;

public class CurrentScale : MonoBehaviour
{
    private float scaleX;

    public void SetScaleX(float value)
    {
        scaleX = value;
    }

    public float GetScaleX()
    {
        return scaleX;
    }
}


