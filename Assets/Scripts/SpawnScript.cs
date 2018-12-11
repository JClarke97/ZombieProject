using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    //creating verables for the place were the enemy will spawn, the time between each spawn and next tiem a enemey can be spawned 
    [SerializeField] GameObject thingToSpawn;
    [SerializeField] float delayBetweenSpawns = 2.0f;
    [SerializeField] float timeOfNextSpawn = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //If enough time has past then spwn a enemy and update next time one can spawn
        if (Time.time >= timeOfNextSpawn)
        {
            //thing to spawn is the object that needs to be spawned transform. position is its position
            //identity is the objects base rotation
            Instantiate(thingToSpawn, transform.position, Quaternion.identity);
            timeOfNextSpawn = Time.time + delayBetweenSpawns;
        }
		
	}
}
