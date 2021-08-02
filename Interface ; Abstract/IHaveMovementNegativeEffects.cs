using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHaveMovementNegativeEffects
{

    void AplySlow(float percentageOfSlow);

    void AplyRepulsion(float repulsionForce);

    void AplyStun(bool stuned);
}
    
