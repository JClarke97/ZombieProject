using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavAnimations : MonoBehaviour {

    NavMeshAgent agent;
    Animator anim;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //printing the speed of the nave mesh agent for debugging purposes

        //if ther is still a agent atached then we give the animator the speed of the agent
        if (agent)
        {
            anim.SetFloat("Speed", agent.velocity.magnitude);
        }
	}
}

