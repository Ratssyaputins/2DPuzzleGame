using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public enum EGameMode
    {
        NOT_SET,
        EASY,
        MEDIUM,
        HARD,
        VERY_HARD
    }

    //  creates a single instance of game settings
    public static GameSettings Instance;

    //sets the Boolean of exit after game is won
    private void Awake()
    {
        _Paused = false;
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(this);

    }

    private EGameMode _GameMode;
    private bool _continuePreviousGame = false;
    private bool _exitAfterWon = false;
    private bool _Paused = false;

    //sets the Boolean of exit after game is won
    public void SetExitAfterWon(bool set)
    {
        _exitAfterWon = set;
        _continuePreviousGame = false;
    }
    //get the exit after the game is won 
    public bool GetExitAfterWon()
    {
        return _exitAfterWon; 
    }
    //  set for continuing game
    public void SetContinuePreviousGame(bool continue_game)
    {
       
        _continuePreviousGame = continue_game;
    }
    //get for continuing game
    public bool GetContinuePreviousGame()
    {
        return _continuePreviousGame;
    }

    //setting the bool for pausing the game
    public void SetPaused(bool paused ) { _Paused = true; }
    //  getting the Boolean for paused game
    public bool GetPaused() { return _Paused; }

    //makes sure game mode is not set and not continue previous game
    void Start()
    {
        _GameMode = EGameMode.NOT_SET;
        _continuePreviousGame = false;

    }

    //   call and sets the enumerator for level of  the game sets of the game mode
    public void SetGameMode(EGameMode mode)
    {
        _GameMode = mode;
    }
    //  setter overload of the game mode 
    public void SetGameMode(string mode)
    {
        if (mode == "Easy") SetGameMode(EGameMode.EASY);
        else if (mode == "Medium") SetGameMode(EGameMode.MEDIUM);
        else if (mode == "Hard") SetGameMode(EGameMode.HARD);
        else if (mode == "VeryHard") SetGameMode(EGameMode.VERY_HARD);
        else  SetGameMode(EGameMode.NOT_SET);
    }
    //returns the string for the selected game mode
    public string GetGameMode()
    {
        switch (_GameMode)
        {
            case EGameMode.EASY: return "Easy";
            case EGameMode.MEDIUM: return "Medium";
            case EGameMode.HARD: return "Hard";
            case EGameMode.VERY_HARD: return "VeryHard";

        }
        Debug.LogError("ERROR: Game Level is not set");
        return " ";
    }

}
