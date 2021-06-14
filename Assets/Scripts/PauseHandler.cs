using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pauseMenu, optionsMenu;
    //method for pausing the game
    void Paused()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
       // Cursor.lockState = CursorLockMode.None;
       // Cursor.visible = true;
    }
    //method for unpausing the game
    public void UnPaused()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        //Cursor.lockState = CursorLockMode.Locked;
       // Cursor.visible = false;
    }
    //sets unpause on start
    private void Start()
    {
        UnPaused();
    }
    //on escape set the pause menu to active and options menu to false
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(optionsMenu.activeSelf)
            {
                optionsMenu.SetActive(false);
                pauseMenu.SetActive(true);
            }
            else
            {
                isPaused = !isPaused;
                if (isPaused)
                {
                    Paused();
                }
                else
                {
                    UnPaused();
                }
            }
        }
    }
}
