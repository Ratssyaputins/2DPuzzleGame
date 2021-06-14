using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWon : MonoBehaviour
{

    public GameObject WinPopup;
    public Text ClockText;

    // Start is called before the first frame update
    void Start()
    {
        WinPopup.SetActive(false);
        ClockText.text = Clock.instance.GetCurrentTimeText().text;
    }

    //sets the popup screen to true and retrieves  the current time for the game duration

    private void OnBoardCompleted()
    {
        WinPopup.SetActive(true);
        ClockText.text = Clock.instance.GetCurrentTimeText().text;
    }
    //Subscribes to OnBoardcompleted event
    private void OnEnable()
    {
        GameEvents.OnBoardcompleted += OnBoardCompleted;
    }
    //Unsubscribes to OnBoardcompleted event
    private void OnDisable()
    {
        GameEvents.OnBoardcompleted -= OnBoardCompleted;
    }
}
