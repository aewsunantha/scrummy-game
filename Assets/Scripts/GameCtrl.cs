using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameCtrl : MonoBehaviour
{
    public InputField[] input;

    public Button yourButton;
    public Text[] showBaht;
    public Text[] errText;
    public Text showPercent;
    public Text pass;
    public float[] values;
    public float[] bath;
    public string[] value2;
    public float[] prevalues;
    public Color[] piceColores;
    public Image picePrefab;
    public Image bg;
    float result;
    public int a = 0;
    public int b = 0;
    bool checkdev = false;
    bool checkdesign = false;
    bool checktest = false;
    bool checkfix = false;
    bool checkpass = false;
    bool checktotalpercent = false;
    public Image bgfade;
    public Image scrum;
    public Button okay;
    public bool chek;
   // public float musicVolume = 1f;
    //public AudioSource audioSource;



    public static object Instance { get; internal set; }

    // public bool check = false;


    void Start()
    {
        



        a = 0;
        b = 0;

        input[0].onValueChanged.AddListener(UpdateDisplayText);
        input[1].onValueChanged.AddListener(UpdateDisplayText);
        input[2].onValueChanged.AddListener(UpdateDisplayText);
        input[3].onValueChanged.AddListener(UpdateDisplayText);
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        //musicVolume = PlayerPrefs.GetFloat("volume");
        //audioSource.volume = musicVolume;
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
    }
    public string LimitInputToTwoChars(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        if (input.Length > 2)
        {
            input = input.Substring(0, 2);
        }

        return input;
    }

    void UpdateDisplayText(string value)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i].text = LimitInputToTwoChars(input[i].text);


            //input[i]=input[i]/()
            //Destroy(MakeGraph); 
            value2[i] = input[i].text;
            prevalues[i] = values[i];

            if (float.TryParse(value2[i], out result))
            {
                values[i] = result;
            }
            else
            {
                values[i] = 0;

            }

            CalPercentToBaht();
            if (values[0] == prevalues[0] && values[1] == prevalues[1] && values[2] == prevalues[2] && values[3] == prevalues[3])
            {
                Button btn = yourButton.GetComponent<Button>();
                btn.onClick.AddListener(ButtonOnclick);
            }
            else
            {
                if (values[0] > 0 || values[1] > 0 || values[2] > 0 || values[3] > 0)
                {
                    Debug.Log("test " + a + " " + picePrefab);

                    if (values[0] < 0 && values[1] < 0 && values[2] < 0 && values[3] < 0)
                    {

                    }
                    else { MakeGraph();  }






                }

            }



        }

        a++;

    }

   
    void ButtonOnclick()
    {


        checkper();
     
        
    }


    void checkper()
    {
        float saveValues = 0;
        for (int i = 0; i < values.Length; i++)
        {
            saveValues += values[i];

            if (saveValues == 100)
            {
                checktotalpercent = true;
            }
            else
            {
                checktotalpercent = false;
            }
        }

        if (values[0] <= 60 && values[0] >= 40)
        { checkdev = true; errText[0].text = " "; }
        else { checkdev = false; errText[0].text = "ควรอยู่ในช่วง 40%-60%"; }


        if (values[1] <= 20 && values[1] >= 5)
        { checkdesign = true; errText[1].text = " "; }
        else { checkdesign = false; errText[1].text = "ควรอยู่ในช่วง 5%-20%"; }

        if (values[2] <= 40 && values[2] >= 20)
        { checktest = true; errText[2].text = " "; }
        else { checktest = false; errText[2].text = "ควรอยู่ในช่วง 20%-40%"; }

        if (values[3] <= 20 && values[3] >= 5)
        { checkfix = true; errText[3].text = " "; }
        else { checkfix = false; errText[3].text = "ควรอยู่ในช่วง 5%-20%"; }


        if (checkdev == true && checkdesign == true && checktest == true && checkfix == true)
        { checkpass = true;
            CheckPercent();

        }
        else { checkpass = false; }


    }



    void MakeGraph()
    {
        float total = 0f;
        float zRotation = 0f;
        for (int i = 0; i < values.Length; i++)
        {
            total += values[i];
        }

        for (int i = 0; i < values.Length; i++) //0,1,2,3
        {
            if (i % 4 == 0)
            {
                Image newbg = Instantiate(bg) as Image;
                newbg.transform.SetParent(transform, false);
            }

            Image newPice = Instantiate(picePrefab) as Image;
            newPice.transform.SetParent(transform, false);
            newPice.color = piceColores[i];
            newPice.fillAmount = values[i] / total;
            newPice.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, zRotation));
            zRotation -= newPice.fillAmount * 360f;

            if (values[i] > 0)
            {
               showPercent.text = input[i].text + "%"; 
               }
        else
        {
            showPercent.text =  "";
        }
            

           /* 
           */
        }
    }

    void CalPercentToBaht()
    {
        string formattedNumber;
        for (int i = 0; i < values.Length; i++)
        {
            bath[i] = (values[i] / 100) * 5000000;

            formattedNumber = bath[i].ToString("n0");

            showBaht[i].text = " " + formattedNumber + "  ฿";
        }
    }

    void CheckPercent()
    {
        chek = false;
        if (checktotalpercent == true && checkpass == true)
        {
            bgfade.gameObject.SetActive(true);
            scrum.gameObject.SetActive(true);
            okay.gameObject.SetActive(true);
            
            pass.text = "คุณจัดการแบ่งงบประมาณได้เหมาะสมแล้ว";
            chek= true;
           
        }
        else
        {
            bgfade.gameObject.SetActive(true);
            scrum.gameObject.SetActive(true);
            okay.gameObject.SetActive(true);

            if (checktotalpercent == false && checkpass == true)
            {
                pass.text = "เปอร์เซ็นรวมทั้งหมดต้องเท่ากับ 100%";
              


            }
            if (checkpass == false && checktotalpercent == true)
            {
                pass.text = "ยังจัดการการแบ่งงบประมาณไม่ถูกต้อง";
       

            }
            if (checktotalpercent == false && checkpass == false)
            {
                pass.text = "เปอร์เซ็นรวมทั้งหมดต้องเท่ากับ 100%  และ ยังจัดการการแบ่งงบประมาณไม่ถูกต้อง";
            }
        }

        Button Confirm = okay.GetComponent<Button>();
        Confirm.onClick.AddListener(TaskOnClickConfirm);

    }

    void TaskOnClickConfirm()
    {
        bgfade.gameObject.SetActive(false);
        scrum.gameObject.SetActive(false);
        okay.gameObject.SetActive(false);
        pass.text = "";
        if(chek == true)
        {
            Goto();
        }
;    }
    public void Goto()
    {
        //PlayerPrefs.SetFloat("data", bath[0]);
       
        SceneManager.LoadScene("Pre1 know");

    }
}
