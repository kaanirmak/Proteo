using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class başla : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;

    public Transform target;

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = target.position;
    }
}
