using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class SeagullAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoRepath = true;
        agent.SetDestination(transform.forward * 10);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (agent.pathStatus != NavMeshPathStatus.PathComplete) return;
        float angle = Random.Range(0f, 360f);
        transform.Rotate(0, angle, 0);
        agent.SetDestination(transform.forward * 10);
    }
}
