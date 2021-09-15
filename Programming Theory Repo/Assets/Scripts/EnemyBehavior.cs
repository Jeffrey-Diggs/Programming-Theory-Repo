using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : Enemy // INHERITANCE
{
    private GameObject[] treesArray;
    private void OnEnable()
    {
        treesArray = GameObject.FindGameObjectsWithTag("Tree");
        //Pick a tree
        //Go there
        //Destroy
        //Repeat
    }
}
