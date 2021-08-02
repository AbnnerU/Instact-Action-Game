using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    private int playerKills;

    [SerializeField] private short[] numberOfEnemysPerSpawn;

    [SerializeField] private short[] minKillToIncreaseMaxEnemies;

    public void IncreasePlayerKills()
    {
        playerKills++;
    }
}
