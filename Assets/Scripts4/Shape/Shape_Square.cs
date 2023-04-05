using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape_Square : MonoBehaviour
{
    public Image occupiedImage;
    // Start is called before the first frame update
    void Start()
    {
        occupiedImage.gameObject.SetActive(false);
    }

  
}
