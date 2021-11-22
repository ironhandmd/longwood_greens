using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    void Start() 
    {
        Time.timeScale = 1f;
        
    
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {

                Resume();

            }
            else
            {

                Paused();

            }

        }


    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Paused()
    {

        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }




}




