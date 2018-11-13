﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int maximumHealth = 100;
    //seting a maximum health variable as 100 which can be changed in the inspector

    [SerializeField] int CurrentHealth = 0;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = maximumHealth;
        // setting the current health the same as max health at the start of the game
    }

    public bool IsDead { get { return CurrentHealth <= 0; } }
    //using IsDead to get the result of the code current health <=0

    public int GetHealth()
    {
        return CurrentHealth;
    }

    public int getMaxHealth()
    {
        return maximumHealth;

    }
    public void Damage(int damageValue)
    {
        CurrentHealth -= damageValue;
        //if the code is equles to or less that 0 then the game object will be destoryed.

        if (CurrentHealth <= 0)
        {
            //if the objects is not nuseing the player tag then add 50 to the players score and destroy the game object
            if (gameObject.tag != "player") //POSIBLE IDEA if (gameObject.tag == "Enemy1")
            {
                UIManager.updateScore(50);
                Destroy(gameObject);

            }

        }

    }
}
