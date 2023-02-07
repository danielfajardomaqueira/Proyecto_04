using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float spawnRange = 9f;
    private Vector3 RandomSpawnPosition()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemyWave (int enemiesToSpawn)
    {
        //DeviceOrientation(int i =; int <enemiesToSpawn; int++){
            //Ínstantiate(enemyPrefab, RandomSpawnPosition(), Quaternion.identity);
        //}
            

    }
}
