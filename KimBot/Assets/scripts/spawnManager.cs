using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public Transform enemyLocation;
    public GameObject enemyPrefab;
    private float spawnRate = 8.0f;
    public float intervalWave;
    public static bool stopSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObject()
    {
        if (!stopSpawn)
        {
            Instantiate(enemyPrefab, enemyLocation.transform.position, enemyPrefab.transform.rotation);
            intervalWave -= -0.01f;
        }
    }
}
