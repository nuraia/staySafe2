using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public float enemySpawnDelay;
    private float currentTime;
    private float lastSpwanedTime;

    void Start()
    {
        lastSpwanedTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;

        if ( currentTime - lastSpwanedTime >= enemySpawnDelay) 
        { SpawnEnemy();
        
        }
    }
    void SpawnEnemy()
    {
        float posX = 11.5f;
        float posY = Random.Range(-4.2f, 4.2f);

        Vector2 pos = new Vector2(posX, posY);
        Instantiate(enemyPrefab, pos, Quaternion.identity);

        lastSpwanedTime = Time.time;
    }
}
