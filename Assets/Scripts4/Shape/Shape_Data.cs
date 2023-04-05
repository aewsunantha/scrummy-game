using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
[System.Serializable]



public class Shape_Data : ScriptableObject
{
    //[System.Serializable]

    public class Row
    { 
        public bool[] column;
        private int _size = 0;
        public Row() { }

        public Row(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int size)
        {
            _size = size;
            column = new bool[_size];
            ClearRow();
        }
        public void ClearRow()
        {
            for (int i = 0; i < _size; i++)
            {
                column[i] = false;
            }
        }
    }
  public int columns = 0;
    public int rows = 0;
  
    public Image feaSubImage;
    public Row[] board;
    internal object gameObject;
    
    public void Clear()
    {
        for (var i = 0; i < rows; i++)
        {
            board[i].ClearRow();
        }
    }
    public void CreateNewBoard()
    {
        
        Debug.Log("test.. : " + feaSubImage.name);

        board = new Row[rows];
        for (var i = 0; i < rows; i++)
        {
            board[i] = new Row(columns);
        }
       
    }


}
