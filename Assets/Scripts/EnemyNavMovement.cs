using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyNavMovement : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agent; //creating a variablet that will hold the navmesh agent.
    
    public Transform target;


	// Use this for initialization
	void Start () {
        //finding seting the target as the player and then set the agents value the NavMeshAgent that is atached to the player
        target = GameObject.FindGameObjectWithTag("Player").transform; 
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
	}
	
	// Update is called once per frame
	void Update () {

        //seting the destination as the player so a path will be calculated.
        agent.SetDestination(target.position);
        if(agent.remainingDistance<(agent.stoppingDistance+0.5f))
            {
            transform.LookAt(target.transform);
        }
		
	}
}
