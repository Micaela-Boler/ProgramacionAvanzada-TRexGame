using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public float spawnTime = 4;
    public float repetition = 5;

    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, repetition);
    }
    
    
    void SpawnEnemy()
    {
        repetition -= 0.01f;
        
        GameObject obstacle = ObjectPool.instance.GetObstacle();
        obstacle.transform.position = spawnPoint.transform.position;
        obstacle.SetActive(true);
    }
}
