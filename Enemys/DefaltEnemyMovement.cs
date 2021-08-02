using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaltEnemyMovement : Movement, IHaveMovementNegativeEffects
{
    
    public void AplyRepulsion(float repulsionForce)
    {
        transform.position += new Vector3(repulsionForce * (-1 * currentScale.GetScaleX()), 0,0);
    }

    public void AplySlow(float percentageOfSlow)
    {
        float percentage = percentageOfSlow / 100;
        moveSpeed = defaltMoveSpeed - (defaltMoveSpeed * percentage);
        //print(moveSpeed);
    }

    public void AplyStun(bool stuned)
    {
        this.stunned = stuned;
    }
}
