using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterScript : MonoBehaviour {
    //creating a reffrence to the game manager.
    GameManager gameManager;


	// Use this for initialization
	void Start () {
        //geting the gammanageer object
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
    private void OnTriggerEnter(Collider other)
    {
        //if the object whos tag ids player then set won to true to trigger win screen
        if(other.tag=="player")
        {
            gameManager.won = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
