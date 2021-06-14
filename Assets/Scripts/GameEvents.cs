using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //delegate to notify when game completed
    public delegate void CheckBoardCompleted();
    //notify if game is completed
    public static event CheckBoardCompleted OnCheckBoardCompleted;

    //notify if game is completed
    public static void CheckBoardCompletedMethod()
    {
        if (OnCheckBoardCompleted != null)
            OnCheckBoardCompleted();
    }
    //assigns a delegate to update the square number
    public delegate void UpdateSquareNumber(int number);
    public static event UpdateSquareNumber OnUpdateSquareNumber;
    //notifies all subscribers that call this function
    public static void UpdateSquareNumberMethod(int number)
    {
        if(OnUpdateSquareNumber !=null)
        OnUpdateSquareNumber(number);
    }

    //  this delegate  is called whenever a certain square is selected in the grid
    public delegate void SquareSelected(int Square_index);
    public static event SquareSelected OnSquareSelected;

    //this published whenever a certain square is selected in the grid
    public static void SquareSelectedMethod(int square_index)
    {
        if (OnSquareSelected !=null)
        OnSquareSelected(square_index);
    }

    //delegate for when the number is incorrect
    public delegate void WrongNumber();
    public static event WrongNumber OnWrongNumber;

    //  publishes when number is incorrect
    public static void OnWrongNumberMethod()
    {
        if (OnWrongNumber != null)
            OnWrongNumber();
    }

    //delegate for when game is ended
    public delegate void GameOver();
    public static event GameOver OnGameOver;

    //Delegate and events for when the game is over 
    public static void OnGameOverMethod()
    {
        if (OnGameOver != null)
            OnGameOver();
    }

    //****************************************
    //delegate for when note is selected
    public delegate void NotesActive(bool active);

    public static event NotesActive OnNotesActive;

    //notifies when not is selected
    public static void OnNotesActiveMethod(bool active)
    {
        if (OnNotesActive != null)
            OnNotesActive(active);
    }

    //****************************************

    //delegate for using clear number
    public delegate void ClearNumber();

    public static event ClearNumber OnClearNumber;
    //notifies when clear is selected
    public static void OnClearNumberMethod()
    {
        if (OnClearNumber!= null) 
            OnClearNumber();
    }


    //****************************************

    public delegate void Boardcompleted();

    public static event Boardcompleted OnBoardcompleted;

    public static void OnBoardcompletedMethod()
    {
        if (OnBoardcompleted != null)
            OnBoardcompleted();
    }

    
}
