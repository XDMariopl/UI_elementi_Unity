using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ObjectMovment : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private RectTransform transformKomponet;
    public Canvas canvas;
    
    void Start() 
    {
        transformKomponet=GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin draging");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Draging object");
        transformKomponet.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Done draging");
    }
}
