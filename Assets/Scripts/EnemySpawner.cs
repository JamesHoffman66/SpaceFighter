using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeZ = 10;
    private float spawnPosX = 38;
    private float spawnPosY = 6;
    private float spawnDelay = 1;
    private float spawnInterval = 1f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ));

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos,
            enemyPrefabs[enemyIndex].transform.rotation);
    }
}
