using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAttack : MonoBehaviour
{
    float nextTimeAttackIsAllowed = -1.0f;

    [SerializeField] float attackDelay = 1.0f;
    //How long betwine attacks and the damage is delt
    [SerializeField] int damageDelt = 5;
    [SerializeField] GameObject BloodSplat;


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

            //holding the direction of the hit as a vector 3 by takeing the direction of the enemy and the position that it was hit
            Vector3 hitDirection = (transform.root.position - other.transform.position).normalized;
            //takes the direction of what we hitand then ds a small amount direction away
            Vector3 hitEffectPos = other.transform.position + (hitDirection * 0.01f) + (Vector3.up * 1.5f);
           //working ouut the dieection in which 
            Quaternion hitEffectRotation = Quaternion.FromToRotation(Vector3.forward, hitDirection);

            Instantiate(BloodSplat, hitEffectPos, hitEffectRotation);
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
