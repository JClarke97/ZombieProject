using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
    //reffrences to UI elemnts to be used in other scripts
    public Slider playerHealth;
    public Text score;
    public Text playerHealthTxt;
    public Text timeTxt;
    public static int amountkilled;
    private bool won;

    // Use this for initialization
    void Start() { 

        

	}
	
	// Update is called once per frame
	void Update () {

        //If the player has survived 180 seconds then the they win
        if (Time.timeSinceLevelLoad > 180)
        {
            won = true;
        }
		
	}
}
