using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryGrid : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
       Debug.Log("Drop");
        if (eventData.pointerDrag != null)
        {
           Debug.Log("Dropped object was: " + eventData.pointerDrag);
        }


        if (transform.childCount == 0)
        {

            GameObject dropped = eventData.pointerDrag;

            DragANDDrop dragdrop = dropped.GetComponent<DragANDDrop>();

           // dragdrop.parentAfterDrag = transform;

           
        }



    }
}
