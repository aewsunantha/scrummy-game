using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //public Text teamnameText ;
   // public string teamname;
    public GameObject Excellent,Good,Fair,Poor,Bad ;
    public int scoredisplay , MinigameNumber;
    public GameObject confirm;


    public float musicVolume = 1f;
    public AudioSource audioSource;



    public void onclick()
    {  
   
        if(MinigameNumber == 2)
        {
            SceneManager.LoadScene("Finute resouremanagement");
        }
        else if (MinigameNumber == 3)
        {
            SceneManager.LoadScene("Finite Userstory");
        }
        else if (MinigameNumber == 4)
        {
            SceneManager.LoadScene("FinitePO");
        }
        else if (MinigameNumber == 5)
        {
            SceneManager.LoadScene("End Minigame4");
        }
        else if (MinigameNumber == 0)
        {
            SceneManager.LoadScene("Final Sp intro");
            

        }
        

    }
    public void excellentFn()
    {
        Excellent.SetActive(true);
        // teamnameText.text = teamname;
        confirm.SetActive(true);

    }
    public void goodFn()
    {
        Good.SetActive(true);
        //teamnameText.text = teamname;
        confirm.SetActive(true);
    }
    public void fairFn()
    {
        Fair.SetActive(true);
        //teamnameText.text = teamname;
        confirm.SetActive(true);
    }
    public void poorFn()
    {
        Poor.SetActive(true);
        //teamnameText.text = teamname;
        confirm.SetActive(true);
    }
    public void badFn()
    {
        Bad.SetActive(true);
        //teamnameText.text = teamname;
        confirm.SetActive(true);
    }
    // Start is called before the first frame update

    void Start()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
        //Set Volume
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;



        //teamname = PlayerPrefs.GetString("Teamname");
        scoredisplay = PlayerPrefs.GetInt("scDisplay");
        MinigameNumber = PlayerPrefs.GetInt("MNo");
        //Invoke("badFn", 5.0f);

        
        switch (scoredisplay)
        {
            case 1:
                Invoke("badFn", 3.0f);

                break;
            case 2:
                Invoke("poorFn", 3.0f);
                break;
            case 3:
                Invoke("fairFn", 3.0f);
                break;
            case 4:
                Invoke("goodFn", 3.0f);
                break;
            case 5:
                Invoke("excellentFn", 3.0f);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
