using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform playerModel;
    CharacterController controller;

    [SerializeField] float movespeed = 5.0f;

    // Use this for initialization
    void Start () {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        //finding the game object that has the tag player

        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = playerModel.position - transform.position;
        direction.y = 0f;

        //if the player models poistion and 
        if ((playerModel.position - transform.position).magnitude > 1.4)
        {
            controller.Move(direction * Time.deltaTime * movespeed);
        }
        //
        transform.LookAt(playerModel);
	}
}
