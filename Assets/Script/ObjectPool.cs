using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance { get; private set; }

    [SerializeField] private List<GameObject> pooledObstacles;
    [SerializeField] int amountToPool;

    [Header("RANDOM OBSTACLE")]
    [SerializeField] private GameObject[] ObstaclePrefabList;
    [SerializeField] GameObject randomObstacle;
    private int randomIndex;


    void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        AddRandomObstaclesToPool();
    }


    private void AddRandomObstaclesToPool()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            randomIndex = Random.Range(0, ObstaclePrefabList.Length);
            randomObstacle = ObstaclePrefabList[randomIndex];

            GameObject obstacle = Instantiate(randomObstacle);
            obstacle.SetActive(false);
            pooledObstacles.Add(obstacle);

            obstacle.transform.parent = transform;
        }
    }


    public GameObject GetObstacle()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObstacles[i].activeSelf)
            {
                return pooledObstacles[i];
            }
        }
        return null;
    }
}
