/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy<T> where T : Enemy
{
    public GameObject GameObject;
    public T ScriptComponent;

    Transform playerModel;
    CharacterController controller;

    

    public Enemy(string name)
    {
        GameObject = new GameObject(name);
        ScriptComponent = GameObject.AddComponent<T>();
    }
}
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] float movespeed = 5.0f;
    Transform playerModel;
    CharacterController controller;

    //
    private void Awake()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        //finding the game object that has the tag player

        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
    }

} 

    