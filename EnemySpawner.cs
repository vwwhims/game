using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] spawnOrder;

    int spawnIndex = 0;

    [SerializeField] float spawnInterval = 2f;
    float spawnCountDown;

    // Start is called before the first frame update
    void Start()
    {
        spawnCountDown = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountDown -= Time.deltaTime;
        if (spawnCountDown <= 0)
        {
            Instantiate(spawnOrder[spawnIndex]);
            spawnIndex++;
            spawnCountDown = spawnInterval;
            if(spawnIndex >= spawnOrder.Length)
            {
                spawnIndex = 0;
            }
        }
    }
}
