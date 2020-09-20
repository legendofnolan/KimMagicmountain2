using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public Transform enemyLocation;
    public GameObject enemyPrefab;

    public float intervalWave;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 1.0f, intervalWave);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObject()
    {
        Instantiate(enemyPrefab, enemyLocation.transform.position, enemyPrefab.transform.rotation);
        intervalWave -= -0.01f;
    }
}
