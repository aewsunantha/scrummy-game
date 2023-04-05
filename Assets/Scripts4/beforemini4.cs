using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class beforemini4 : MonoBehaviour
{
    public Button buttonB;
    public Button buttonB1;
    public Button buttonB2;
    public Button buttonB3;
    public Image selectNum;
    public Image selectNum1;
    public Image selectNum2;
    public Image selectNum3;
    public Button confirm;
    public string getindex;
   
    public Text showtext;
    public Image bgfade;
    public Image scrum;
    public Button okay;
    public bool chek;
    void Start()
    {

        Button Confirm =confirm.GetComponent<Button>();
        Confirm.onClick.AddListener(TaskOnClickConfirm);
   


        Button btn = buttonB.GetComponent<Button>(); 
        btn.onClick.AddListener(TaskOnClick);
        Button btn1 = buttonB1.GetComponent<Button>(); 
        btn1.onClick.AddListener(TaskOnClick1);
        Button btn2 = buttonB2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = buttonB3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);

        selectNum.gameObject.SetActive(false);
        selectNum1.gameObject.SetActive(false);
        selectNum2.gameObject.SetActive(false);
        selectNum3.gameObject.SetActive(false);
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();


    }


    public void ChangeButtonColor(Color color)
    {
        GetComponent<Image>().color = color;
    }


    void TaskOnClickOK()
    {
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        showtext.text = " ";


        if (chek == true)
        {
          SceneManager.LoadScene("Howto 4");
        }
        
    }
    void TaskOnClickConfirm()

    {
        chek = false;
        bgfade.gameObject.SetActive(true);
        scrum.gameObject.SetActive(true);
        okay.gameObject.SetActive(true);

        if (getindex == "8")
        {
            Debug.Log("pass");
            showtext.text = "คุณกำหนดจำนวน sprint ได้เหมาะสมแล้ว";
            chek = true;
        }
        else { Debug.Log("fail");
            showtext.text = "คุณยังกำหนดจำนวน sprint ไม่เหมาะสม";
        }


        Button Confirm1 = okay.GetComponent<Button>();
        Confirm1.onClick.AddListener(TaskOnClickOK);
    }

    void TaskOnClick()
    {
        Debug.Log(buttonB.name);
        getindex = buttonB.name;
        selectNum.gameObject.SetActive(true);
        selectNum1.gameObject.SetActive(false);
        selectNum2.gameObject.SetActive(false);
        selectNum3.gameObject.SetActive(false);


    }
    void TaskOnClick1()
    {
        Debug.Log(buttonB1.name);
        getindex = buttonB1.name;
        selectNum.gameObject.SetActive(false);
        selectNum1.gameObject.SetActive(true);
        selectNum2.gameObject.SetActive(false);
        selectNum3.gameObject.SetActive(false);


       



    }
    void TaskOnClick2()
    {

        Debug.Log(buttonB2.name);
        getindex = buttonB2.name;
        selectNum.gameObject.SetActive(false);
        selectNum1.gameObject.SetActive(false);
        selectNum2.gameObject.SetActive(true);
        selectNum3.gameObject.SetActive(false);

    }
    void TaskOnClick3()
    {

        Debug.Log(buttonB3.name);
        getindex = buttonB3.name;
        selectNum.gameObject.SetActive(false);
        selectNum1.gameObject.SetActive(false);
        selectNum2.gameObject.SetActive(false);
        selectNum3.gameObject.SetActive(true);
    }



}