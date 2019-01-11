using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour {
    //creating variables for the charicter controller
    CharacterController varController;
    [SerializeField] float jumpSpeed = 20.0f;
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;
    [SerializeField] float moveSpeed = 5.0f;
    public int playerNum;

    

    

    // Use this for initialization
    void Start () {

        //geting the charicterController from the player
        varController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //+player number seperating the inputs from diffrent controllers 
        float x = Input.GetAxis("JoystickX" + playerNum);
        //geting the joysticks input and saveing it
        //float X = Input.GetAxis("JoystickX");
        //geting a copy of rotation of the object
        Vector3 rot = transform.localEulerAngles;
        //adding joystick value x value times 5 
        rot.y += x * 5;
        //seting the now rotation as the players current rotation
        transform.localEulerAngles = rot;

        //Geting the H and V values  from the horizontal and vertical axis

        float h = Input.GetAxis("Horizontal" + playerNum);
        float v = Input.GetAxis("Vertical" + playerNum);
        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * moveSpeed;

        //if the player is grounded then the player can jump
        if (varController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }
        }
        else
        {
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;
        velocity = transform.TransformDirection(velocity);
        varController.Move(velocity * Time.deltaTime);


    }
}
