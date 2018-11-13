using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoookX : MonoBehaviour {

    [SerializeField] float sensitivity = 5.0f;
    //create a field that lets you edit the variable in the unity inspector

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        // checking what the moues value is  iseing input, when the value is minus it will move left witht he opersit for moveing right.
	}
}
