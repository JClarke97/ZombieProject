using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //when the presses the F key a raycast will shoot form the center of there screen.
		if (Input.GetKeyDown(KeyCode.F))
        { Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            //geting the infomation from the raycast
            RaycastHit hitInfo;
            
            if(Physics.Raycast(mouseRay, out hitInfo))
            {
                //opening the door by enableing the door open script if object that was hit was a door
                DoorOpenScript door = hitInfo.transform.GetComponent<DoorOpenScript>();
                if (door)
                {
                    door.enabled = true;
                }
            }
        }
	}
}
