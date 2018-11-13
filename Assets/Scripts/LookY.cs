using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour {

    [SerializeField] float sensitivityY;
    //create a field that lets you edit the variable in the unity inspector

    public float minimumY = -30F;
    public float maximumY = 30F;
    //seting up how far the player can move the camera

    float rotationY = 0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        //geting the y axis and adding to the rotation of the player

        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        //if the variable is below the minimum, set it to minimum. If it’s above, set it to max

        transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
	}

}
