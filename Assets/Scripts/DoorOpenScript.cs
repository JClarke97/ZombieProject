using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour {
    //actions are carryed out when the script is enabled.
    void OnEnable()
    {
        //seting the transform position of the object to equal to new vector 3
        //which has the values of were the dorr currently is plus 3 on the 7 direction toi rise the door
       
    }

    private void Start()
    {
        StartCoroutine("OpenDelay");
    }
    private void OnDisable()
    {
        this.transform.position =
            new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
    }

    IEnumerator OpenDelay()
    {
        yield return new WaitForSeconds(5);

        this.transform.position =
           new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
    }

}
