using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DProtect : MonoBehaviour
{
    public static Protect checkpoint;

   public GameObject first, second, third, fourth, fifth, sixth;


    public int[] choiceArray = new int[6];
    public int count = 0;
    public Text chooseText;
    public Text SceneR2;

    public GameObject close;
    public void closeScrum()
    {
        close.SetActive(false);
    }

    public void onClickchoice1()
    {
        
        if (count < 2)
        {   
            
            if (choiceArray[0] == 0 )
            {
                choiceArray[0] = 1;
                count++;
                first.SetActive(true);

            }
            else
            {
                choiceArray[0] = 0;
                count--;
                first.SetActive(false);
            }

           
        }
        else if(count == 2 && choiceArray[0]==1)
        {
            choiceArray[0] = 0;
            count--;
            first.SetActive(false);
            Debug.Log("--");

        }
            Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
            Debug.Log(count);
            chooseText.text = count.ToString();

    }

    public void onClickchoice2()

    {

        if (count < 2)
        {
            if (choiceArray[1] == 0)
            {
                choiceArray[1] = 1;
                count++;
                second.SetActive(true);
            }
            else
            {
                choiceArray[1] = 0;
                count--;
                second.SetActive(false);
            }
           
        }
        else if (count == 2 && choiceArray[1] == 1)
        {
            
            count--;
            choiceArray[1] = 0;
            second.SetActive(false);
            Debug.Log("--");
        }

        Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
        Debug.Log(count);
        chooseText.text = count.ToString();
    }

    public void onClickchoice3()
    {

        if (count < 2)
        {
            if (choiceArray[2] == 0)
            {
                choiceArray[2] = 1;
                count++;
                third.SetActive(true);
            }
            else
            {
                choiceArray[2] = 0;
                count--;
                third.SetActive(false);
            }
           
        }
        else if (count == 2 && choiceArray[2] == 1)
        {
            choiceArray[2] = 0;
            count--;
            third.SetActive(false);
            Debug.Log("--");
        }
        Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
        Debug.Log(count);
        chooseText.text = count.ToString();

    }


    public void onClickchoice4()
    {
        if (count < 2)
        {
            if (choiceArray[3] == 0)
            {
                choiceArray[3] = 1;
                count++;
                fourth.SetActive(true);
            }
            else
            {
                choiceArray[3] = 0;
                count--;
                fourth.SetActive(false);
            }
           
        }
        else if (count == 2 && choiceArray[3] == 1)
        {
            choiceArray[3] = 0;
            count--;
            fourth.SetActive(false);
            Debug.Log("--");
        }
        Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
        Debug.Log(count);
        chooseText.text = count.ToString();
    }

    public void onClickchoice5()
    {
        if (count < 2)
        {
            if (choiceArray[4] == 0)
            {
                choiceArray[4] = 1;
                count++;
                fifth.SetActive(true);
            }
            else
            {
                choiceArray[4] = 0;
                count--;
                fifth.SetActive(false);
            }
           
        }
        else if (count == 2 && choiceArray[4] == 1)
        {
            choiceArray[4] = 0;
            count--;
            fifth.SetActive(false);
            Debug.Log("--");
        }
        Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
        Debug.Log(count);
        chooseText.text = count.ToString();
    }

    public void onClickchoice6()
    {

        if (count < 2)
        {
            if (choiceArray[5] == 0)
            {
                choiceArray[5] = 1;
                count++;
                sixth.SetActive(true);
            }
            else
            {
                choiceArray[5] = 0;
                count--;
                sixth.SetActive(false);
            }
            
        }
        else if (count == 3 && choiceArray[5] == 1)
        {
            choiceArray[5] = 0;
            count--;
            sixth.SetActive(false);
            Debug.Log("--");
        }

        Debug.Log(choiceArray[0] + "" + choiceArray[1] + "" + choiceArray[2] + "" + choiceArray[3] + "" + choiceArray[4] + "" + choiceArray[5]);
        Debug.Log(count);
        chooseText.text = count.ToString();
    }



    public void LoadSceneD2()
    {
        SceneManager.LoadScene("D2");
        PlayerPrefs.SetInt("data0", choiceArray[0]);
        PlayerPrefs.SetInt("data1", choiceArray[1]);
        PlayerPrefs.SetInt("data2", choiceArray[2]);
        PlayerPrefs.SetInt("data3", choiceArray[3]);
        PlayerPrefs.SetInt("data4", choiceArray[4]);
        PlayerPrefs.SetInt("data5", choiceArray[5]);

        if(choiceArray[3] ==1 && choiceArray[5] == 1)
        {
            PlayerPrefs.SetInt("min5Design", 5);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
        DoNotDestroy2.instance.GetComponent<AudioSource>().Play();



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
