using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CountButton : MonoBehaviour,
    //IPointerDownHandler,
    //IPointerUpHandler,
    IPointerClickHandler


{
    public System.Action onClickCallback;



    //[SerializeField] private CanvasGroup _canvasGroup;

    //�^�b�v
    public void OnPointerClick(PointerEventData eventData)
    {
        onClickCallback?.Invoke();
    }




    //�^�b�v�_�E��
    //public void OnPointerDown(PointerEventData eventData)
    //{

    //}
    ////�^�b�v�A�b�v
    //public void OnPointerUp(PointerEventData eventData) 
    //{

    //}

    

}