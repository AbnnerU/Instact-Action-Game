using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    [SerializeField] private EnemiesLevels enemiesLevels;
    [SerializeField] private GameObject enemiesContainer;

    [SerializeField] private GameObject spawnPointLeft;

    [SerializeField] private GameObject spawnPointRigth;

    [SerializeField] private float timeForFistWave;

    [SerializeField] private float timeBetweenSpawnSides;

    [SerializeField] private float timeBetweenWaves;

    [SerializeField] private float[] distanceBetweenEnemies;

    [SerializeField] private short[] numberOfEnemysPerSpawn;

    [SerializeField] private short[] minKillToIncreaseMaxEnemies;

    [SerializeField] private short[] minKillsToEnableEnemyTier;

    private int playerKills;

    private int currentMaxEnemiesId;

    private int currentMaxTierId;

    private int currentMaxTier;

    private short minEnemies;

    private short maxEnemies;

    private short enemiesWaveAmount;

    private void Start()
    {
        minEnemies = numberOfEnemysPerSpawn[0];

        maxEnemies = numberOfEnemysPerSpawn[1];

        currentMaxTier = 1;

        currentMaxTierId = 1;

        currentMaxEnemiesId = 2;

        StartCoroutine(FirtWave(timeForFistWave));

    }

    IEnumerator FirtWave(float time)
    {
        yield return new WaitForSeconds(time);

        print("Start Firt Wave");

        CallWaves();

        StopCoroutine(FirtWave(time));
    }

    private void CallWaves()
    {
        short numberOfEnemiesLeft = (short)Random.Range(minEnemies, maxEnemies);
        short numberOfEnemiesRight = (short)Random.Range(minEnemies, maxEnemies);

        int total = numberOfEnemiesLeft + numberOfEnemiesRight;
        enemiesWaveAmount = (short)total;

        StartCoroutine(EnemyWaveLeft(numberOfEnemiesLeft));

        StartCoroutine(EnemyWaveRight(numberOfEnemiesRight));
    }

    IEnumerator EnemyWaveLeft(short enemiesAmount)
    {
        //Spanw Enemies On left side

        for (int i = 0; i < enemiesAmount; i++)
        {
            GameObject obj = PoolManager.SpawnObject(enemiesLevels.ChooseOneEnemy(currentMaxTier),
                new Vector2(spawnPointLeft.transform.position.x, -2.19f),
                Quaternion.identity);

            obj.transform.SetParent(enemiesContainer.transform);

            obj.transform.localScale = new Vector2(1, 1);

            obj.GetComponent<CurrentScale>().SetScaleX(1);


            float distance = distanceBetweenEnemies[(int)Random.Range(0, distanceBetweenEnemies.Length)];

            yield return new WaitForSeconds(distance);
        }

        yield return new WaitForSeconds(timeBetweenSpawnSides);
        
        StopCoroutine(EnemyWaveLeft(enemiesAmount));
       
    }

    IEnumerator EnemyWaveRight(short enemiesAmount)
    {
        //Spanw Enemies On rigth side
        for (int i = 0; i < enemiesAmount; i++)
        {
            GameObject obj = PoolManager.SpawnObject(enemiesLevels.ChooseOneEnemy(currentMaxTier),
                new Vector2(spawnPointRigth.transform.position.x, -2.19f),
                Quaternion.identity);

            obj.transform.SetParent(enemiesContainer.transform);

            obj.transform.localScale = new Vector2(-1, 1);

            obj.GetComponent<CurrentScale>().SetScaleX(-1);

            float distance = distanceBetweenEnemies[(int)Random.Range(0, distanceBetweenEnemies.Length - 1)];

            //print("Distance (" + i + ") : " + distance);

            yield return new WaitForSeconds(distance);
        }

        StopCoroutine(EnemyWaveRight(enemiesAmount));
    }


    public void IncreasePlayerKills()
    {
        playerKills++;

        DecreaseCurrentWaveNumber();

       if (currentMaxEnemiesId <= minKillToIncreaseMaxEnemies.Length - 1)
        {
            if (playerKills == minKillToIncreaseMaxEnemies[currentMaxEnemiesId])
            {

                maxEnemies = numberOfEnemysPerSpawn[currentMaxEnemiesId];

                currentMaxEnemiesId++;

            }
        }

       if(currentMaxTierId <= minKillsToEnableEnemyTier.Length - 1)
        {
            if(playerKills == minKillsToEnableEnemyTier[currentMaxTierId])
            {
                currentMaxTier++;

                currentMaxTierId++;
            }
        }

       
    }



    private void DecreaseCurrentWaveNumber()
    {
        enemiesWaveAmount--;

        if (enemiesWaveAmount == 0)
        {
            CallWaves();
        }
    }

}
