using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public GameObject pausePanel;
    public GameObject optionsPanel;
    //  when escape key is pressed set the pause panel to true else unpause
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel.activeInHierarchy == false && optionsPanel.activeInHierarchy == false)
            {
                Time.timeScale = 0;
                pausePanel.gameObject.SetActive(true);
            }
            else
            {
                Unpause();
            }
                
        }
    }
    //method for unpausing the game
    public void Unpause()
    {
        Time.timeScale = 1;
        pausePanel.gameObject.SetActive(false);
        optionsPanel.gameObject.SetActive(false);
    }
}
