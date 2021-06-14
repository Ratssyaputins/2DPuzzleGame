using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadEasyGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.EASY);

        SceneManager.LoadScene(name);
    }

    public void LoadMediumGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.MEDIUM);

        SceneManager.LoadScene(name);
    }

    public void LoadHardGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.HARD);

        SceneManager.LoadScene(name);
    }

    public void LoadVeryHardGame(string name)
    {
        GameSettings.Instance.SetGameMode(GameSettings.EGameMode.VERY_HARD);

        SceneManager.LoadScene(name);
    }

    //activates and deactivates the object that is passed thru for the relevant button
    public void ActiveObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void DeActiveObject(GameObject obj)
    {
        obj.SetActive(false);
    }
    public void SetPause(bool paused)
    {
        GameSettings.Instance.SetPaused(paused);
    }

    public void ContinuePreviousGame(bool continue_game)
    {
        GameSettings.Instance.SetContinuePreviousGame(continue_game);
    }

    public void ExitAfterWon()
    {
        GameSettings.Instance.SetExitAfterWon(true);
    }
}
