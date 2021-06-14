using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ContinueButton : MonoBehaviour
{
    public Text timeText;
    public Text levelText;

    //converts int to string for time
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
   
    //if file exist it will load the game otherwise new game
    void Start()
    {
        if(Config.GameDataFileExist() == false)
        {
            gameObject.GetComponent<Button>().interactable = false;
            timeText.text = " ";
            levelText.text = " ";
        }
        else
        {
            float delta_time = Config.ReadGameTime();
            delta_time += Time.deltaTime;
            TimeSpan span = TimeSpan.FromSeconds(delta_time);

            string hour = LeadingZero(span.Hours);
            string minute = LeadingZero(span.Minutes);
            string seconds = LeadingZero(span.Seconds);

            timeText.text = hour + ":" + minute + ":" + seconds;
            levelText.text = Config.ReadBoardLevel();
        }
    }

    // sets the saved game level
    public void SetGameData()
    {
        GameSettings.Instance.SetGameMode(Config.ReadBoardLevel());
    }
    
}
