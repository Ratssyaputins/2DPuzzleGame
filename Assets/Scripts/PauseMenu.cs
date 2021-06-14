using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Text time_text;
    //Get the current time for the game when paused
    public void DisplayTime()
    {
        time_text.text = Clock.instance.GetCurrentTimeText().text;
    }
}
