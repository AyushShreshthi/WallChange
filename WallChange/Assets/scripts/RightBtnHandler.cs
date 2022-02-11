using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightBtnHandler : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerController.left = false;
        PlayerController.right = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerController.right = false;
    }
}
