using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverScreen;

    public static bool isGameStarted;
    public GameObject startingText; 
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isGameStarted = true;
            Destroy(startingText);
        }

        if (gameOver)
        {   
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
    }
    
}
