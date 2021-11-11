using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatController : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent meshAgent;
    public Animator ani;
    void Start()
    {
        meshAgent.SetDestination(new Vector3(0,0,0));
        meshAgent.isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
