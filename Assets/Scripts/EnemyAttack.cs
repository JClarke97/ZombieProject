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
            //other is used to see what is attached to the thing that is inside of the trigger.
            //if this is ture then we get the player health sctipt via get component
            Health playerHealth = other.GetComponent<Health>();
            //triggering the attack animation
            anim.SetTrigger("Attack");
            playerHealth.Damage(damageDelt); //calling damage fuction
            nextTimeAttackIsAllowed = Time.time + attackDelay; //upadate the time in which the next attack can be used
        }
        
    }

    //obtaining the animator
    Animator anim;
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


    }
}
