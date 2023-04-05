using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GridSquare : MonoBehaviour
{
    public Image hooverImage;
    public Image activeImage;
    public Image normalImage;
    public List<Sprite> normalImages;
    // Start is called before the first frame update
    public bool Selected { get; set; }
    public int SquareIndex { get; set; }
    public bool SquarOccupied { get; set; }
    
    
    void Start()
    {
        Selected = false;
        SquarOccupied = false;
    }



    // Update is called once per frame
    public void SetImage(bool setFirstImage0)
    {
        Debug.Log("SetImage");
        normalImage.GetComponent<Image>().sprite = setFirstImage0 ? normalImages[1] : normalImages[0];
        
    } 
}
