using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] arrayPrefab;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, arrayPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-15, 15), 0, 20);
        Instantiate(arrayPrefab[index], spawnPos, arrayPrefab[index].transform.rotation);
    }
}
