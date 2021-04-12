using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Lives : MonoBehaviour
{
    public List<GameObject> error_images;
    public GameObject game_over_popup; //?????????????????Video 7
 
    int lives_ = 0;
    int error_number_ = 0;

    // Start is called before the first frame update
    void Start()
    {
        lives_ = error_images.Count;
        error_number_ = 0;
    }

    // Update is called once per frame
    private void WrongNumber()
    {
        if(error_number_ < error_images.Count)
        {
            error_images[error_number_].SetActive(true);
            error_number_++;
            lives_--;
        }
        CheckForGameOver();
    }

    private void CheckForGameOver()
    {
        if(lives_ <= 0)
        {
            GameEvents.OnGameOverMethod();
            game_over_popup.SetActive(true);
        }
    }
    private void OnEnable()
    {
        GameEvents.OnWrongNumber += WrongNumber;
    }
    private void OnDisable()
    {
        GameEvents.OnWrongNumber -= WrongNumber;
    }
}
