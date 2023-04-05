using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TQuestion : MonoBehaviour
{

    public GameObject choice1, choice2, choice3, choice4;
    public GameObject CorrectChoice;
    public int scoremin5 = 5;

    public GameObject close;
    public GameObject scrumwin;
    public void closeScrum()
    {
        close.SetActive(false);
    }
    public void Scrum()
    {
        close.SetActive(true);
    }

    public void gotoT2()
    {
        SceneManager.LoadScene("T2");
    }

    public void choicecheck1()
    {
        if (CorrectChoice == choice1)
        {
            Debug.Log("Pass");
            if (scoremin5 <= 1) {
                scoremin5 = 1;
            }
            PlayerPrefs.SetInt("min5test", scoremin5);
            scrumwin.SetActive(true);



        }
        else
        {
            Scrum();
            scoremin5--;
            Debug.Log("-1");
            choice1.SetActive(false);

        }

    }
    public void choicecheck2()
    {
        if (CorrectChoice == choice2)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5test", scoremin5);
            scrumwin.SetActive(true);


        }
        else
        {
            Scrum();
            scoremin5--;
            Debug.Log("-1");
            choice2.SetActive(false);

        }

    }
    public void choicecheck3()
    {
        if (CorrectChoice == choice3)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5test", scoremin5);
            scrumwin.SetActive(true);

        }
        else
        {
            Scrum();
            scoremin5--;
            Debug.Log("-1");
            choice3.SetActive(false);

        }

    }
    public void choicecheck4()
    {
        if (CorrectChoice == choice4)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5test", scoremin5);
            scrumwin.SetActive(true);

        }
        else
        {
            Scrum();
            scoremin5--;
            Debug.Log("-1");
            choice4.SetActive(false);

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
