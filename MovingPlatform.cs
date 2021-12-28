using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingPlatform : MonoBehaviour
{

    public Transform end;
    public NavMeshAgent platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       platform.SetDestination(end.position);
    }
}
