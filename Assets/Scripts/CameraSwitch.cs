using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject Camera1;

    public GameObject Camera2;

    // Use this for initialization
    void Start () {

        //starting the game with Camera1 as active as it is going to be the main camera
        Camera1.SetActive(true);
        Camera2.SetActive(false);
		
	}
	
	// Update at set to run depending on how many steps are set in time settigns 
	void FixedUpdate () {
        //creating a line that shows the raycast
        Debug.DrawRay(transform.position, (transform.position + (new Vector3(10, 0, 0))), Color.red);
        //starting the Raycast and seeing and having it oinght from the right of the cube
        //seting the distance that the rayst to go  to 10
        //if we hit something we make camera 2 active else set camera 1 active.
        if (Physics.Raycast(transform.position, transform.right, 10))
        {

            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        else
        {
            Camera2.SetActive(false);
            Camera1.SetActive(true);
        }
		
	}
}
