using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private const int V = 0;
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    [HideInInspector] public Transform parentAfterDrag;   
    [HideInInspector] public string previousRole;
    [HideInInspector] public Transform previousP;
    [HideInInspector] public Transform currentPP;
    [HideInInspector] public List<int> numbers1 = new List<int>();
    [HideInInspector] public List<string> roleCheck1 = new List<string>();
    [HideInInspector] public List<GameObject> numbersCheck1 = new List<GameObject>();

    public Image image;
   
    private void Start()
    {
        previousP = transform.parent;
        currentPP = transform.parent;
        numbers1.Clear();
        numbersCheck1.Clear();
        roleCheck1.Clear();
        LevelManager.Instance.estimateTime = 16;
        Debug.Log(LevelManager.Instance.checkM[0].name);
        image = GetComponent<Image>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    { 

        Debug.Log("Begin Drag");
        if (eventData == null)
        {
            return;
        }
        previousP = transform.parent;
        previousRole = transform.name; //p1
        Debug.Log("test : " +previousRole);
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        Debug.Log("img : " + image.raycastTarget);
        image.raycastTarget = false;


    }
    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition;

  
    }
    public void OnEndDrag(PointerEventData eventData)
    {
       
        Debug.Log("End Drag");
        if (eventData == null)
        {
            return;
        }
        transform.SetParent(parentAfterDrag);
        Debug.Log("img : "+image.raycastTarget);
        image.raycastTarget = true;
        currentPP = transform.parent;
        LevelManager.Instance.score(previousP, currentPP, eventData);
        LevelManager.Instance.score2(numbers1, numbersCheck1);
        LevelManager.Instance.score4(eventData);
        LevelManager.Instance.shownickname(eventData);
    }
   

    

}









