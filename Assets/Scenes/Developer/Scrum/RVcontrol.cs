using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RVcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject i1,i2,i3,i4,i5;
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

    public void nextmirr()
    {
        yourButton.transform.SetAsLastSibling();
    }

    void Start()
    {
        click = 1;
        Invoke("im1", 1f);
        Invoke("im2", 2f);
        Invoke("im3", 3f);
        Invoke("im4", 4f);
        Invoke("im5", 5f); 
        Invoke("PM",  6f); 
        Invoke("nextmirr",  6.5f); 
   
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
        else if (click == 5)
        {
            SceneManager.LoadScene("Retro");
        }
        else
        {

        }
      

    }





}
