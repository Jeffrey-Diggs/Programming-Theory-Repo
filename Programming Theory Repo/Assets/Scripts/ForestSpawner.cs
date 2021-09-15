using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpawner : MonoBehaviour
{
    public GameObject[] treesArray;
    public int treesAmount;
    public Vector3 treeRandomPos;

    void Start()
    {
        treesAmount = Random.Range(100, 500);

        for (int i = 0; i < treesAmount; i++)
        {
            treeRandomPos = new Vector3(Random.Range(-75, 85), -3.8f, Random.Range(-39, 145));
            Instantiate(treesArray[Random.Range(0, treesArray.Length)],treeRandomPos,Quaternion.Euler(0, Random.Range(0, 360),0));
        }
    }


}
