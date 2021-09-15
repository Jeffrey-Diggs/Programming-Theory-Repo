using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    private GameObject[] spawnersArray;
    public GameObject[] enemiesArray;
    public int enemiesAmount = 10;

    private void Start()
    {
        spawnersArray = GameObject.FindGameObjectsWithTag("Spawner");

        foreach (var spawner in spawnersArray)
        {
            for (int i = 0; i < enemiesAmount; i++)
            {
                Instantiate(enemiesArray[Random.Range(0, enemiesArray.Length)], spawner.transform.position, Quaternion.identity);
            }
        }
    }
}
