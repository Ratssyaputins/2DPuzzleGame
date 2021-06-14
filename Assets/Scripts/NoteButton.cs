using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NoteButton : Selectable, IPointerClickHandler
{
    public Sprite on_image;
    public Sprite off_image;

    private bool active_;

    // sets default at start is false for notes
    void Start()
    {
        active_ = false;
    }
    //  sets off onPointerClick on input so that the image is retrieved for activating notes and vice versa.Initiates OnNotesActiveMethod in the GameEvents Class.
    public void OnPointerClick(PointerEventData eventData)
    {
        active_ = !active_;
        if (active_)
            GetComponent<Image>().sprite = on_image;
        else
            GetComponent<Image>().sprite = off_image;
        GameEvents.OnNotesActiveMethod(active_);
    }
}
