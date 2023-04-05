using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {


        if (transform.childCount == 0)
        {
            Debug.Log("Drop");
            // Debug.Log(eventData.pointerDrag);//p1
            GameObject dropped = eventData.pointerDrag;
            // Debug.Log(eventData.pointerEnter);//
            DragDrop dragdrop = dropped.GetComponent<DragDrop>();
            dragdrop.parentAfterDrag = transform;


            bool ans;
            bool ans2;
            bool[] check = { false, false, false, false, false, false, false, false, false };
            bool check1;
            for (int i = 0; i < LevelManager.Instance.checkMM.Length; i++)
            {
                ans = Equals(dragdrop.parentAfterDrag, LevelManager.Instance.checkMM[i]);

                if (ans == true)
                {
                    check[i] = true;

                    for (int j = 0; j < LevelManager.Instance.checkM.Length; j++)
                    {
                        ans2 = Equals(eventData.pointerDrag, LevelManager.Instance.checkM[j]);
                        if (ans2 == true)
                        {
                            dragdrop.parentAfterDrag = LevelManager.Instance.checkMM[j];

                        }
                        else
                        {
                        }
                    }
                }
                else
                {


                }

            }

            if ((check[0] == check[1] && check[2] == check[3] && check[4] == check[5] && check[6] == check[7]) == check[8])
            {

               // Debug.Log("not select ");
                check1 = false;
            }
            else
            {
                //Debug.Log("selected");
                check1 = true;
            }

            //Debug.Log("Enter.........."+eventData.pointerEnter);
            //Debug.Log("Drag........" +eventData.pointerDrag);


            Debug.Log("end.....................");

        }



    }
}
