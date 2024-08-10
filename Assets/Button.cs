using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{

    [SerializeField] private Transform obj;
    [SerializeField] private bool isLeft;

    private float speed = 0.01f;
    private float time = 0f;
    private bool isDown = false;

    private void Update()
    {
        if (isDown) {
            time += Time.deltaTime;
            if (isLeft)
            {
                obj.transform.Translate(-1 * speed * time, 0, 0);
            }
            else
            {
                obj.transform.Translate(1 * speed * time, 0, 0);
            }
            
        }
    }

    public System.Action onClickCallback;
    // タップ  
    public void OnPointerClick(PointerEventData eventData) { }
    // タップダウン  
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }
    // タップアップ  
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }
}
