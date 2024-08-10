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

    //タップ
    public void OnPointerClick(PointerEventData eventData)
    {
        onClickCallback?.Invoke();
    }




    //タップダウン
    //public void OnPointerDown(PointerEventData eventData)
    //{

    //}
    ////タップアップ
    //public void OnPointerUp(PointerEventData eventData) 
    //{

    //}

    

}