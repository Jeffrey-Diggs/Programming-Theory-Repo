using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    private GameObject[] deadTreesArray;

    private void Start()
    {
        deadTreesArray = GameObject.FindGameObjectsWithTag("DeadTree");
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ReplaceWithDeadTree();
        }
    }

    public void ReplaceWithDeadTree()
    {
        int randomDeadTree = Random.Range(0, deadTreesArray.Length);
        Instantiate(deadTreesArray[randomDeadTree], transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
