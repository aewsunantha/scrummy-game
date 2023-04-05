using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shape : MonoBehaviour, IBeginDragHandler, 
                                    IDragHandler, 
                                    IPointerUpHandler,
                                    IPointerDownHandler , 
                                    IEndDragHandler
{
    public GameObject squareShapeImage;
    public Vector3 shapeSelectedScale;
    public Vector2 offset = new Vector2(0f, 700f);
    //[HideInInspector]
    public Shape_Data CurrentShapeData;
    private Vector3 _shapeStartScale;
    private RectTransform _transform;
    private List<GameObject> currentShape = new List<GameObject>();
   // private bool _shapeDraggable= true;
    private Canvas _canvas;

    public void Awake()
    {
        _shapeStartScale = this.GetComponent<RectTransform>().localScale;
        _transform = this.GetComponent<RectTransform>();
        _canvas = GetComponentInParent<Canvas>();
        //_shapeDraggable = true;
       
    }
     void Start()
    {
        RequestNewShape(CurrentShapeData);
    }


    public void RequestNewShape(Shape_Data shape_data)
     {
         CreateShape(shape_data);
     }
    
    public void CreateShape(Shape_Data shape_data)
    {
        CurrentShapeData = shape_data;
        var totalSquareNumber = GetNumberOfSquares(shape_data);
       
        while (currentShape.Count <= totalSquareNumber)
        {
            currentShape.Add(Instantiate(squareShapeImage, transform) as GameObject);
        }
        foreach(var square in currentShape)
        {
            square.gameObject.transform.position = Vector3.zero;
            square.gameObject.SetActive(false);

        }
        var squareRect = squareShapeImage.GetComponent<RectTransform>();
       
        var moveDistance = new Vector2(squareRect.rect.width * squareRect.localScale.x,
            squareRect.rect.height * squareRect.localScale.y);

        int currentINdexInList = 0;
        for(var row =0; row < shape_data.rows; row++)
        {
            for(var column = 0; column < shape_data.columns; column++)
            {
               currentShape[currentINdexInList].SetActive(true);
                currentShape[currentINdexInList].GetComponent<RectTransform>().localPosition =
                    new Vector2(GetXPositionForShapeSquare(shape_data,column,moveDistance),
                    GetYPositionForShapeSquare(shape_data,row,moveDistance));
                currentINdexInList++;
            }
        }
   
    }
    
    public float GetYPositionForShapeSquare(Shape_Data shape_data, int row, Vector2 moveDistance)
    {
        float shiftOnY = 0f;
        if (shape_data.rows > 1)
        {
            if (shape_data.rows % 2 != 0)
            {
                var middleSquareIndex = (shape_data.rows - 1) / 2;
                var multiplier = (shape_data.rows - 1) / 2;
                if (row < middleSquareIndex)
                {
                    shiftOnY= moveDistance.y * -1;
                    shiftOnY *= multiplier;
                }
                else if (row > middleSquareIndex)
                {
                    shiftOnY = moveDistance.y * 1;
                    shiftOnY *= multiplier;
                }
            }
            else
            {
                var middleSqureIndex2 = (shape_data.rows == 2) ? 1 : (shape_data.rows / 2);
                var middleSqureIndex1 = (shape_data.rows == 2) ? 0 : (shape_data.rows) - 1;
                var mutiplier = shape_data.rows/ 2;

                if (row == middleSqureIndex1 || row == middleSqureIndex2)
                {
                    if (row == middleSqureIndex2)
                        shiftOnY = (moveDistance.y / 2)* -1;
                    if (row == middleSqureIndex1)
                        shiftOnY = (moveDistance.y / 2);

                }
                if (row < middleSqureIndex1 && row < middleSqureIndex2)
                {
                    shiftOnY = moveDistance.y * 1;
                    shiftOnY *= mutiplier;
                }
                else if (row > middleSqureIndex1 && row > middleSqureIndex2)
                {
                    shiftOnY = moveDistance.y * -1;
                    shiftOnY *= mutiplier;
                }
            }
        }
        return shiftOnY;
    }


    public float GetXPositionForShapeSquare(Shape_Data shape_data, int column, Vector2 moveDistance)
    {
        float shiftOnX = 0f;
        if (shape_data.columns > 1 )
        {
            if (shape_data.columns % 2 != 0)
            {
                var middleSquareIndex = (shape_data.columns - 1) / 2;
                var multiplier = (shape_data.columns - 1) / 2;
                if (column < middleSquareIndex)
                {
                    shiftOnX = moveDistance.x * -1;
                    shiftOnX *= multiplier;
                } else if (column > middleSquareIndex)
                {
                    shiftOnX = moveDistance.x * 1;
                    shiftOnX *= multiplier;
                }
            }
            else
            {
                var middleSqureIndex2 = (shape_data.columns == 2) ? 1 : (shape_data.columns / 2);
                var middleSqureIndex1 = (shape_data.columns == 2) ? 0 : (shape_data.columns) - 1;
                var mutiplier = shape_data.columns / 2;

                if (column == middleSqureIndex1 || column == middleSqureIndex2)
                {
                    if (column == middleSqureIndex2)
                        shiftOnX = moveDistance.x / 2;
                    if (column == middleSqureIndex1)
                        shiftOnX = (moveDistance.x / 2) * -1;

                }
                if(column <middleSqureIndex1 && column < middleSqureIndex2)
                {
                    shiftOnX = moveDistance.x * -1;
                    shiftOnX *= mutiplier;
                }else if(column > middleSqureIndex1 && column > middleSqureIndex2)
                {
                    shiftOnX = moveDistance.x * 1;
                    shiftOnX *= mutiplier;
                }
            }
        }
        return shiftOnX;
    }

   
    private int GetNumberOfSquares(Shape_Data shape_data)
    {
        int number = 0;

        foreach(var rowData in shape_data.board)
        {
            foreach(var active in rowData.column)
            {
                if (active)
                    number++;

            }
        }
        return number;
    }
  

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(" OnPointerUp");

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        this.GetComponent<RectTransform>().localScale = shapeSelectedScale;

    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        _transform.anchorMin = new Vector2( 0, 0);
        _transform.anchorMax = new Vector2( 0, 0);
        _transform.pivot = new Vector2(0, 0);

        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_canvas.transform as RectTransform,
            screenPoint: eventData.position, Camera.main, localPoint: out pos);
        _transform.localPosition = pos + offset;

    }
 
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log(" OnEndDrag");

        this.GetComponent<RectTransform>().localScale = _shapeStartScale;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

    }
}
