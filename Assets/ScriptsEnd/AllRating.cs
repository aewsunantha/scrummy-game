using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllRating : MonoBehaviour
{
    public Image[] starmini1;
    public Image[] starmini2;
    public Image[] starmini3;
    public Image[] starmini4;
    public Image[] starmini5;
    public int mini1;
    public int mini2;
    public int mini3;
    public int mini4;
    public int mini5;
    public int scoreall;
    public Button next;
    void Start()
    {


        mini1 = PlayerPrefs.GetInt("mini1");
        mini2 = PlayerPrefs.GetInt("mini2");
        mini3 = PlayerPrefs.GetInt("mini3");
        mini4 = PlayerPrefs.GetInt("mini4");
        mini5 = PlayerPrefs.GetInt("mini5");

        if (mini1 <= 0)
        {
            mini1 = 1;
        } 
        if (mini2 <= 0)
        {
            mini2 = 1;
        } 
        if (mini3 <= 0)
        {
            mini3 = 1;
        } 
        if (mini4 <= 0)
        {
            mini4 = 1;
        } if (mini5 <= 0)
        {
            mini5 = 1;
        }

        Button Confirm = next.GetComponent<Button>();
        next.onClick.AddListener(clicknext);

        for(int i=0; i < 5-mini1; i++) 
        {
        starmini1[4-i].gameObject.SetActive(false);
        }
        
        
        for(int i=0; i < 5-mini2; i++) 
        {
            starmini2[4 - i].gameObject.SetActive(false);

        }

        for (int i=0; i < 5-mini3; i++)
        {
            starmini3[4 - i].gameObject.SetActive(false);

        }

        for (int i=0; i < 5-mini4; i++)
        {
            starmini4[4 - i].gameObject.SetActive(false);

        }

        for (int i=0; i < 5-mini5; i++) 
        {
            starmini5[4 - i].gameObject.SetActive(false);
        }

        scoreall = (mini1 + mini2 + mini3 + mini4 + mini5) / 5;
    }
    void clicknext()
    { 
        //next scene 
        //send all score
        PlayerPrefs.SetInt("player_score", scoreall);
        SceneManager.LoadScene("totalscore");
    }
    
}
