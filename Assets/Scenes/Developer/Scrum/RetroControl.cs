using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetroControl : MonoBehaviour
{
    public GameObject well1, well2,well3, poor1, poor2,poor3, imp1,imp2,imp3,scrum;
    public Button button;
    public int Numclick = 1;
    public InputField wellinput, poorinput,impinput;
    public Text showyoutext_1, showyoutext_2,showyoutext_3;


    public void scrumclose()
    {
        scrum.SetActive(false);

        Invoke("Well1", 1f);
        Invoke("Well2", 2f);
        Invoke("Poor1", 3f);
        Invoke("Poor2", 4f);
        Invoke("Poor2", 4f);
        Invoke("Imp1", 5f);
        Invoke("Imp2", 6f);
        Invoke("Input1", 7f);
        Invoke("Input2", 7f);
        Invoke("Input3", 7f);
    }
    public void TaskOnClick()
    {
        if (Numclick > 1)
        {
            //next Scence
        }
    }

    public void Input1()
    {
        wellinput.gameObject.SetActive(true);
    }
    public void Input2()
    {
        poorinput.gameObject.SetActive(true);
    }
    public void Input3()
    {
        impinput.gameObject.SetActive(true);
    }
    public void Well1()
    {
        well1.SetActive(true);
    }
    public void Well2()
    {
        well2.SetActive(true);
    }
    public void Well3()
    {
        well3.SetActive(true);
    }
    public void Poor1()
    {
        poor1.SetActive(true);
    }
    public void Poor2()
    {
        poor2.SetActive(true);
    }
    public void Poor3()
    {
        poor3.SetActive(true);
    }
    public void Imp1()
    {
        imp1.SetActive(true);
      
    }
    public void Imp2()
    {
        imp2.SetActive(true);
    }
    public void Imp3()
    {
        imp3.SetActive(true);
    }
    public void BTN()
    {
        button.gameObject.SetActive(true);

    }

    public void saveData1()
    {
       string data1 = wellinput.text;
        showyoutext_1.text = data1;
        wellinput.text = "";
        Well3();
        BTN();


    }
    public void saveData2()
    {
        string data2 = poorinput.text;
        showyoutext_2.text = data2;
        poorinput.text = "";
        Poor3();
        BTN();

    }
    public void saveData3()
    {
        string data3 = impinput.text;
        showyoutext_3.text = data3;
        impinput.text = "";
        Imp3();
        BTN();

    }

    public void loadscene()
    {
        SceneManager.LoadScene("Mini 5 know");
    }


    void Start()
    {   




        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        showyoutext_1.text = wellinput.text;
        showyoutext_2.text = poorinput.text;
        showyoutext_3.text = impinput.text;



    }
 
}
