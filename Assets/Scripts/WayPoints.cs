using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent agent;
    //List of array of points- starts at number 0
    public GameObject wayPoints;
    Transform[] points;
    public int destPoints = 0;

    
	// Use this for initialization
	void Start () {
        //seting points to be equal to the resuls of “GetComponentsInChildren<Transform>” on all of the waypoints
        //this is quicker than makeing a public and haveing to drag them one by one
        points = wayPoints.GetComponentsInChildren<Transform>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //Canturnoffautobraking to not stop between waypoints
        agent.autoBraking = false;
        GotoNextPoint();
	}
    //this is called everyeverytime a wapoint have been touched
    void GotoNextPoint()
    {
        //checking to see if there are waypoints before sending the enemeie to the next waypoint that is stored in destpoints

        if (points.Length == 0)
        {
            return;
        }
        agent.SetDestination (points [destPoints].position);
    }
	
	// Update is called once per frame
	void Update () {
		if(agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
	}
}