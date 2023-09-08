using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int gameState = -1;
    // 0 = Main Menu
    // 1 = Story Mode
    // 2 = Free Play

    void Start(){
        gameState = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ReloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

