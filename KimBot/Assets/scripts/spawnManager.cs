using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public Transform enemyPrefab;
    //public GameObject enemyPrefab;

    public float intervalWave;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("spawnObject", 1.0f, intervalWave);
    }

    void SpawnObject()
    {
        Instantiate(enemyPrefab, enemyPrefab.transform.position, enemyPrefab.transform.rotation);
    }
}
