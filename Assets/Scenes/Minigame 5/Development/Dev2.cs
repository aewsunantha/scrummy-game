using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dev2 : MonoBehaviour
{
    public Protect protect;
    public int[] choiceArray = new int[6];
    public bool[] choiceTrue = new bool[3];
    public Text SceneDev2;
    public GameObject first, second, third;
    public void fix1()
    {
        if (choiceArray[0] == 0)
        {
            PlayerPrefs.SetInt("databack", 1);
            SceneManager.LoadScene("Dev3.1");
            //  choiceArray[0] = 1;
            PlayerPrefs.SetInt("data0", 1);

        }
        else
        {

        }

    }
    public void fix2()
    {
        if (choiceArray[1] == 0)
        {
            PlayerPrefs.SetInt("databack", 2);
            SceneManager.LoadScene("Dev3.2");
            // choiceArray[4] = 1;
            PlayerPrefs.SetInt("data1", 1);
        }
        else
        {

        }

    }
    public void fix3()
    {
        if (choiceArray[3] == 0)
        {
            PlayerPrefs.SetInt("databack", 3);
            SceneManager.LoadScene("Dev3.3");
           // choiceArray[5] = 1;
            PlayerPrefs.SetInt("data3", 1);
        }
        else
        {

        }

    }

    public void gotoDev2()
    {
        DoNotDestroy2.instance.GetComponent<AudioSource>().Pause();

        SceneManager.LoadScene("Dev22");
    }

    public void checkChoice()
    {

        if (choiceArray[0] == 1 && choiceArray[1] == 1 && choiceArray[3] == 1)
        {

            SceneDev2.text = "Pass";
            Invoke("gotoDev2", 4f);
            first.SetActive(true);
            second.SetActive(true);
            third.SetActive(true);
        }
        else if (choiceArray[0] == 1 && choiceArray[1] == 1)
        {
            first.SetActive(true);
            second.SetActive(true);
            SceneDev2.text = "Fix choice 3";


        }
        else if (choiceArray[1] == 1 && choiceArray[3] == 1)
        {
            second.SetActive(true);
            third.SetActive(true);
            SceneDev2.text = "Fix choice 1";
        }
        else if (choiceArray[0] == 1 && choiceArray[3] == 1)
        {
            first.SetActive(true);
            third.SetActive(true);
            SceneDev2.text = "Fix choice 2";

        }
        else if (choiceArray[0] == 1)
        {
            first.SetActive(true);
            SceneDev2.text = "Fix choice 2 and 3";
        }
        else if (choiceArray[1] == 1)
        {
            second.SetActive(true);
            SceneDev2.text = "Fix choice 1 and 3";
        }
        else if (choiceArray[3] == 1)
        {
            third.SetActive(true);
            SceneDev2.text = "Fix choice 1 and 2";
        }
        else
        {

            SceneDev2.text = "Fix choice 1  2 and 3 ";
        }

    }



    private void Awake()
    {

        choiceArray[0] = PlayerPrefs.GetInt("data0");
        choiceArray[1] = PlayerPrefs.GetInt("data1");
        choiceArray[2] = PlayerPrefs.GetInt("data2");
        choiceArray[3] = PlayerPrefs.GetInt("data3");
        choiceArray[4] = PlayerPrefs.GetInt("data4");
        choiceArray[5] = PlayerPrefs.GetInt("data5");



        foreach (int i in choiceArray)
        {
            Debug.Log(" " + i);
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        checkChoice();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
