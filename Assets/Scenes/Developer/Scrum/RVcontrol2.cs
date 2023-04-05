using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RVcontrol2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject i1,i2,i3,i4,i5,i6,i7;
    public GameObject ii1,ii2,ii3,ii4,ii5,ii6;
    public GameObject pm,po,sm,all;
    public Button yourButton;
    public int click;
    public void im1()
    {
        i1.SetActive(true);
    }
    public void im2()
    {
        
        i2.SetActive(true);

    }
    public void im3()
    {
      
        i3.SetActive(true);
    }
    public void im4()
    {
       
        i4.SetActive(true);
    }
       public void im5()
    {
       
        i5.SetActive(true);
    }     
      public void im6()
    {
       
        i6.SetActive(true);
    }
       public void im7()
    {
       
        i7.SetActive(true);
    }

    public void imm1()
    {
        ii1.SetActive(true);

    }
    public void imm2()
    {

        ii2.SetActive(true);

    }
    public void imm3()
    {

        ii3.SetActive(true);

    }
    public void imm4()
    {

        ii4.SetActive(true);

    }
    public void imm5()
    {

        ii5.SetActive(true);

    }
    public void imm6()
    {

        ii6.SetActive(true);

    }



    public void PM()
    {
        pm.SetActive(true);
        po.SetActive(false);
        sm.SetActive(false);
    }
    public void PO()
    {

        po.SetActive(true);
        pm.SetActive(false);
        sm.SetActive(false);

    }
    public void SM()
    {

        sm.SetActive(true);
        po.SetActive(false);
        pm.SetActive(false);
    }

    public void mirrnext()
    {
        yourButton.transform.SetAsLastSibling();
    }

    void Start()
    {
       
        click = 1;
        Invoke("im1", 1f);
        Invoke("im2", 2f);
        Invoke("im3", 2.5f);
        Invoke("im4", 3f);
        Invoke("im5", 3.5f); 
        Invoke("im6", 4f);   
        Invoke("im7", 4.5f); 
        
        Invoke("imm1", 5f);
        Invoke("imm2", 5.5f);
        Invoke("imm3", 6f);
        Invoke("imm4", 6.5f);
        Invoke("imm5", 7f); 
        Invoke("imm6", 7.5f);
        
        Invoke("PM",  8f);
        Invoke("mirrnext", 8.5f);

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }
    void TaskOnClick()
    {
        click++;
     if(click == 2)
        {
            po.SetActive(true);
            pm.SetActive(false);
            sm.SetActive(false);

        }else if(click == 3)
        {
            sm.SetActive(true);
            po.SetActive(false);
            pm.SetActive(false);
        }else if(click == 4)
        {
            sm.SetActive(false);
            po.SetActive(false);
            pm.SetActive(false);
            all.SetActive(true);
        }
        else
        {

        }
      

    }





}
