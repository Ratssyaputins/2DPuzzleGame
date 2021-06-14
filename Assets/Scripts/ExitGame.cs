using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    //exit the game to main screen
    public void Close()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

    }
}
