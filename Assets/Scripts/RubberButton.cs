using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RubberButton : Selectable, IPointerClickHandler
{
    //initiates the rubber function
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.OnClearNumberMethod();
    }
}
