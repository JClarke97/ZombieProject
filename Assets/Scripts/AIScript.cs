using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIScript : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    public GameObject[] points;
    public int destPoint = 0;
    public Health health;
    public Transform healthpoint;

    public Transform player;
    public int chaseDistance;
    public int findDistance;

    //creating a enumerated type to  let me decler the behaviourrs I want
    public enum Behaviours { patrol, Combat, Heal };
    //creating a variabl;e to say what the current behaviour is
    public Behaviours currBehaviour = Behaviours.patrol;

    void Start()
        //geting the current health value form the health script
    {
        health = GetComponent<Health>();
        //esting the agent to the nav mesh agent thats ataced to the NPC
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //creating reffrences to the player pick ups and waypoints
        player = GameObject.FindGameObjectWithTag("Player").transform;
        healthpoint = GameObject.FindGameObjectWithTag("pick up").transform;
        points = GameObject.FindGameObjectsWithTag("Waypoint");
    }
    void Update()
    {
        //print(Vector3.Distance(transform.position, player.position));
        if (health.GetHealth() <25)
        {
            currBehaviour = Behaviours.Heal;
        }
        RunBehaviours();
    }

    void RunBehaviours()
    {
        //checas what the current behaviour is and then runs the code asosiate it with that behaviour.
        switch (currBehaviour)
        {
            case Behaviours.patrol:
                RunPatrolstate();
                break;
            case Behaviours.Combat:
                RunCombatState();
                break;
            case Behaviours.Heal:
                RunHealstate();
                break;

        }
    }
    void RunPatrolstate()
    {
        //if the distance between the NPC and the player is less than the find distance set the state to comabt
        // this is means if hte enemies is close to the player it will start attacing them.
        if (Vector3.Distance(transform.position, player.position) < findDistance)
        {

            print("patrol to combat");
            currBehaviour = Behaviours.Combat;
        }
        //seting the destinationif the NPC is 0.5 units away from the player.
        

        else if (agent.remainingDistance < 1.1f)
        {
            if (points.Length ==0)
            {
                return;
            }
            agent.SetDestination(points[destPoint].transform.position);
            destPoint = (destPoint + 1) % points.Length;
        }
    }
    void RunCombatState()
    {
        //checking to see is if the player further that the caseing distace value away form toe NPC
        //If it has then revett back to patroling.
        if (Vector3.Distance(transform.position, player.position) > chaseDistance)
        {
            currBehaviour = Behaviours.patrol;
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }
    void RunHealstate()

    {
        //seting the destination to the health pick up 
        agent.SetDestination(healthpoint.position);
        //if the NPC is on the health pack then pick up then return to patroling 
        if (agent.remainingDistance <0.1f)
        {
            currBehaviour = Behaviours.patrol;
        }
    }
   
}
