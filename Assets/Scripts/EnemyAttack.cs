using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAttack : MonoBehaviour
{
    float nextTimeAttackIsAllowed = -1.0f;

    [SerializeField] float attackDelay = 1.0f;
    //How long betwine attacks and the damage is delt
    [SerializeField] int damageDelt = 5;

    void OnTriggerStay(Collider other) //when an object is in the trigger this is called
    {
        if (other.tag == "Player" && Time.time >= nextTimeAttackIsAllowed)
        {
            Health playerHealth = other.GetComponent<Health>(); //other is used to see what is attached to the thing that is inside of the trigger. if this is ture then we get the player health sctipt via get component
            playerHealth.Damage(damageDelt); //calling damage fuction
            nextTimeAttackIsAllowed = Time.time + attackDelay; //upadate the time in which the next attack can be used
        }
        
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}
