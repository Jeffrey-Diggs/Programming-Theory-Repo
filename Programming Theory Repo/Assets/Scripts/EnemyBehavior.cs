using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : Enemy // INHERITANCE
{
    private GameObject[] m_treesArray;
    private NavMeshAgent m_navMeshAgent;
    private Animator m_animatorController;
    private void OnEnable()
    {
        m_navMeshAgent = GetComponent<NavMeshAgent>();

        if (m_animatorController == null)
            return;
        else
            m_animatorController = GetComponent<Animator>();
        //Destroy
        //Repeat
        PickATree();
    }

    void PickATree()
    {
        m_treesArray = GameObject.FindGameObjectsWithTag("Tree");
        int randomTree = Random.Range(0, m_treesArray.Length);

        m_animatorController.SetBool("IsWalking", true);
        m_navMeshAgent.SetDestination(m_treesArray[randomTree].transform.position);
    }
}
