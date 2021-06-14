using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public Text textClock;

    // Get the current time of the game to display in game over menu
    void Start()
    {
        textClock.text = Clock.instance.GetCurrentTimeText().text;
    }

    
}
