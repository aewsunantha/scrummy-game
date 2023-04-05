using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragANDDrop : MonoBehaviour, IBeginDragHandler,
                                    IDragHandler,
                                    IEndDragHandler
{
    public GameObject[] squareImage;

    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private Vector3 _startPosition;


    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();


    }
                               
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;

    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;


    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("OnEndDrag");
        Debug.Log("Drag :" + eventData.pointerDrag);
        Debug.Log("Enter :" + eventData.pointerEnter);
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;


        CtrlGame4.Instance.test2(eventData,squareImage);

    }

 
   
}
