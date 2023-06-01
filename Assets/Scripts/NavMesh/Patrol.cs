using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
       
    public Transform[] pointsPatrol;

    private int indexPoint = 0;

    UnityEngine.AI.NavMeshAgent agent;
    
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        SetNextPointPatrol(0);
    }

    void Update() {
        Debug.Log($">>>>>>>>>>>>> {agent.destination} - {transform.position} = {Mathf.Abs((agent.destination - transform.position).magnitude)}");
        if (Mathf.Abs((agent.destination - transform.position).magnitude) < 1.4f ) SetNextPointPatrol(indexPoint++ % pointsPatrol.Length);
    }

    void SetNextPointPatrol(int i) {
        agent.destination = pointsPatrol[i].position;
    }


}