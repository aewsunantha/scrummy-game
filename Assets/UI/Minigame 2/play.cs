using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{

     public GameObject Painpoint,Personal,Solution,Value,Confirm;
     public GameObject  Choice1, Choice2, Choice3, Choice4;
     public GameObject Requirement, Game;
     public GameObject miniheart1, miniheart2, miniheart3, miniheart4, miniheart5;
     public GameObject Scrummaster,scrumwin,scrumhelp;
        public int score = 5;
     public Text scoreText;
     public Text pass;

     Vector2  Choice1InitPos , Choice2InitPos , Choice3InitPos , Choice4InitPos;


    public void getScore(int scoreX)
    {
        scoreText.text = "Score: " + scoreX.ToString();

    }

    public void DragChoice( GameObject Choicex)
    {
        Choicex.transform.position = Input.mousePosition;
    }

     
    public void scrum()
    {
        
        if (score <= 1)
        {
            score = 1;
            scrumhelp.SetActive(true);
        }
        else Scrummaster.SetActive(true);

    }
    public void scrumclose()
    {

        Scrummaster.SetActive(false);
    }

    public void nonehelp()
    {

        scrumhelp.SetActive(false);
    }

    public void DropChoice( GameObject Choice ,Vector2 ChoiceInitPos)
    {
        float Distance1 = Vector2.Distance(Choice.transform.position, Painpoint.transform.position );
        float Distance2 = Vector2.Distance(Choice.transform.position, Personal.transform.position);
        float Distance3 = Vector2.Distance(Choice.transform.position, Solution.transform.position);
        float Distance4 = Vector2.Distance(Choice.transform.position, Value.transform.position);

        if (Distance1 < 200)
        {
            Choice.transform.position = Painpoint.transform.position;
        }
        else if(Distance2 < 200)
        {
            Choice.transform.position = Personal.transform.position;

        }
        else if (Distance3 < 200)
        {
            Choice.transform.position = Solution.transform.position;

        }
        else if (Distance4 < 200)
        {
            Choice.transform.position = Value.transform.position;

        }
        else
        {
            Choice.transform.position = ChoiceInitPos;
        }

    }

    public void DropChoice1()
    {   
        DropChoice(Choice1 ,Choice1InitPos);
        
        
    }

    public void DropChoice2()
    {
        DropChoice(Choice2 , Choice2InitPos);
    }

    public void DropChoice3()
    {
        DropChoice(Choice3 , Choice3InitPos);
    }

    public void DropChoice4()
    {
        DropChoice(Choice4 , Choice4InitPos);
    }


    public void DragChoice1()
    {
        DragChoice(Choice1);
    }

    public void DragChoice2()
    {
        DragChoice(Choice2);
    }

    public void DragChoice3()
    {
        DragChoice(Choice3);
    }

    public void DragChoice4()
    {
        DragChoice(Choice4);
    }

    public void backtoGame()
    {
        Game.SetActive(true);
        Requirement.SetActive(false);

    }
    public void backtoRequirement()
    {
        Requirement.SetActive(true);
        Game.SetActive(false);


    }

    public void knowledge()
    {
        PlayerPrefs.SetInt("scDisplay", score);
        PlayerPrefs.SetInt("mini2", score);
        SceneManager.LoadScene("Mini 2 know");
    }
    
    public void gotoscore()
    {   
        SceneManager.LoadScene("Score");
    }
    public void Scorecal()
    {
       

        if (Choice1.transform.position == Solution.transform.position && Choice2.transform.position == Personal.transform.position
            && Choice3.transform.position == Painpoint.transform.position && Choice4.transform.position == Value.transform.position)
        {
           
            pass.text = "Pass" ;
            Debug.Log("Pass");
            Debug.Log(score);
            PlayerPrefs.SetInt("scDisplay", score);
            PlayerPrefs.SetInt("mini2", score);
            scrumwin.SetActive(true);

            
        }

        else if(true)

        {
            Debug.Log("else");
            if (Choice1.transform.position != Solution.transform.position)
            {
                
                Choice1.transform.position = Choice1InitPos;

            }
            if (Choice2.transform.position != Personal.transform.position)
            {
                
                Choice2.transform.position = Choice2InitPos;
            }
            if (Choice3.transform.position != Painpoint.transform.position)
            {
                
                Choice3.transform.position = Choice3InitPos;
            }
            if (Choice4.transform.position != Value.transform.position)
            {
                
                Choice4.transform.position = Choice4InitPos;
            }

            scrum();

            score -= 1; 

            if (score <=1)
            {
                score = 1;
                
            }

            if (score == 4)
            {
                miniheart5.SetActive(false);
            }
            else if (score == 3)
            {
                miniheart4.SetActive(false);
            }
            else if (score == 2)
            {
                miniheart3.SetActive(false);
            }
            else if (score == 1)
            {
                miniheart2.SetActive(false);
                

            }

            Debug.Log("Fail");
            Debug.Log(score);
            getScore(score);
             
        }

    }
 
   

    void Start()
    {
       

        Choice1InitPos = Choice1.transform.position;
        Choice2InitPos = Choice2.transform.position;
        Choice3InitPos = Choice3.transform.position;
        Choice4InitPos = Choice4.transform.position;
        scrumhelp.SetActive(false); 
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();

    }

    



}
  