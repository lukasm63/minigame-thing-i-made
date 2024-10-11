using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public GameObject brick;


    void Start()
    {
        InvokeRepeating("SpawnBrick", startDelay, spawnInterval);
    }

private float spawnRangeX = 15;
private float spawnPosZ = 20;

    // Update is called once per frame
    void Update()
    {
        
        }
            // Randomly generate brick spawn position
           
        
    void SpawnBrick() {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate (brick, spawnPos, transform.rotation);
    }
}