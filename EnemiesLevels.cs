using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesLevels : MonoBehaviour
{
    [SerializeField] private GameObject[] tierOneEnemies;

    [SerializeField] private GameObject[] tierTwoEnemies;

    [SerializeField] private GameObject[] tierThreeEnemies;

    [SerializeField] private GameObject[] tierFourEnemies;

    public GameObject ChooseOneEnemy(int maxTier)
    {
        int chooseTier = (int)Random.Range(1, maxTier + 1);

        if(chooseTier == 1)
        {
           int enemyId = ChooseEnemyNumber(tierOneEnemies.Length);

            return tierOneEnemies[enemyId];

        }
        else if(chooseTier == 2)
        {
            int enemyId = ChooseEnemyNumber(tierTwoEnemies.Length);

            return tierTwoEnemies[enemyId];
        }
        else if(chooseTier == 3)
        {
            int enemyId = ChooseEnemyNumber(tierThreeEnemies.Length);

            return tierThreeEnemies[enemyId];
        }
        else
        {
            int enemyId = ChooseEnemyNumber(tierFourEnemies.Length);

            return tierFourEnemies[enemyId];
        }
        
    }


    private int ChooseEnemyNumber(int legth)
    {
        return (int)Random.Range(0, legth);
    }
}
