using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class problem : MonoBehaviour
{
    public string teamname;
    //public Text teamnameText;
    public Text text;
    public GameObject chatbox;
    public int round = 0;
    
    public void openChatbox()
    {


        chatbox.SetActive(true);
        //teamnameText.text = teamname;

    }

    public void gotoProblem()
    {

        switch (round)
        {
            case 1:
                round++;
                PlayerPrefs.SetInt("problem", round);
                SceneManager.LoadScene("Require1");

                break;
            case 2:
                round++;
                PlayerPrefs.SetInt("problem", round);
                SceneManager.LoadScene("Dev1");
                break;
            case 3:
                round++;
                PlayerPrefs.SetInt("problem", round);
                SceneManager.LoadScene("Design1");
                break;
            case 4:
                round=1 ;
                PlayerPrefs.SetInt("problem", round);
                SceneManager.LoadScene("Test1");
                break;

        }


    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        round = PlayerPrefs.GetInt("problem");
        
        if(round== 0) { 
        round = 1;
            Debug.Log(round);
                       
        }
        teamname = PlayerPrefs.GetString("Teamname");
        Invoke("openChatbox", 4.0f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
