/************
 * Name: Ryan Scheppler
 * Date: 1/4/2021
 * Desc: Add this to an object over the actual pause menu objects to turn on and off
 * 
 * note this is from the platformer game
 * **********/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuObjects;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseMenuObjects.SetActive(true);
    }
    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        pauseMenuObjects.SetActive(false);
    }
}
