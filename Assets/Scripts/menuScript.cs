using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void loadMain()

    {
        //loading scene 1 in the index
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}



