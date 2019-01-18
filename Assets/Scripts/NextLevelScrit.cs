using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelScrit : MonoBehaviour {

    GameManager gameManager;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="player")
        {
            gameManager.won = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
