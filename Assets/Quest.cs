using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest : MonoBehaviour
{   
    public GameObject productOwner , Developer;
    public GameObject[] Mission = new GameObject[6];
    public GameObject[] MissionTask = new GameObject[7];
    public GameObject person1, person2, person3, person4, person5, person6, person7, person8;
  //  public int[] checkMission = new int[6];
    public float x, y, z ,xDev,yDev,zDev;
    
    public int i = 0;
    public int ibefore=0 ;
    public Vector3 LoadPos;

    public GameObject setting,settingwindow,mute;
    public void settingclick()
    {
        settingwindow.SetActive(true);
    }

    public void closesetting()
    {
        settingwindow.SetActive(false);
    }

    public void mutesound()
    {
        mute.SetActive(true);
    }
    public void unmute()
    {
        mute.SetActive(false);
    }

    public void newgame()
    {

        SceneManager.LoadScene("GameStarts");
    }
    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }


    public void OnTriggerEnter(Collider Target)

    {
        
        if (Target.gameObject.tag == "Mission")

           {
            // Debug.Log(i);
             Mission[i].SetActive(false); 

            if (i == 0)
            {
                savePosition();
               
                i++;
                SceneManager.LoadScene("Project Requirement");
                PlayerPrefs.SetInt("MNo",i);
                Mission[i].SetActive(true);
               


            }
            else if(i == 1)
            {
                i++;
                savePosition();
               
                SceneManager.LoadScene("Howto Pre1");
                PlayerPrefs.SetInt("MNo", i);
                Mission[i].SetActive(true);



            }
            else if (i == 2)
            {
                savePosition();
                i++;
                SceneManager.LoadScene("BeforeUserstory");
                
                PlayerPrefs.SetInt("MNo", i);
                Mission[i].SetActive(true);
                


            }
            else if (i == 3)
            {
                savePosition();
                i++;
                SceneManager.LoadScene("Howto 3");
               
                PlayerPrefs.SetInt("MNo", i);
                Mission[i].SetActive(true);

                PlayerPrefs.SetFloat("xposDev", -11.84f);
                PlayerPrefs.SetFloat("yposDev", 6.13f);
                PlayerPrefs.SetFloat("zposDev", -7.07f);

            }
            else if (i == 4)
            {
                
                savePositionDev();
                i++;
                SceneManager.LoadScene("Start Minigame 4");
               
                PlayerPrefs.SetInt("MNo", i);
                Mission[i].SetActive(true);
                

            }
            else if (i == 5)
            {
               
                savePositionDev();
                i =0;
                SceneManager.LoadScene("Scrum Intro");
                
                PlayerPrefs.SetInt("MNo", i);
                Mission[i].SetActive(true);


            }
            else { }

            
            

           }
            
        
        

    }

    public void  savePosition()
    {

        x = productOwner.transform.position.x;
        y = productOwner.transform.position.y;
        z = productOwner.transform.position.z;

        PlayerPrefs.SetFloat("xpos", x);
        PlayerPrefs.SetFloat("ypos", y);
        PlayerPrefs.SetFloat("zpos", z);

        Debug.Log(x + "/" + y + "/" + z);



    }

    public void loadPosition()
    {
        x = PlayerPrefs.GetFloat("xpos");
        y = PlayerPrefs.GetFloat("ypos");
        z = PlayerPrefs.GetFloat("zpos");

         LoadPos = new Vector3(x, y, z);
        productOwner.transform.position = LoadPos;
        productOwner.SetActive(true);
    }

    public void savePositionDev()
    {

        xDev = Developer.transform.position.x;
        yDev = Developer.transform.position.y;
        zDev = Developer.transform.position.z;

        PlayerPrefs.SetFloat("xposDev", xDev);
        PlayerPrefs.SetFloat("yposDev", yDev);
        PlayerPrefs.SetFloat("zposDev", zDev);

        



    }

    public void loadPositionDev()
    {
        xDev = PlayerPrefs.GetFloat("xposDev");
        yDev = PlayerPrefs.GetFloat("yposDev");
        zDev = PlayerPrefs.GetFloat("zposDev");

        LoadPos = new Vector3(xDev, yDev, zDev);
        Developer.transform.position = LoadPos;
        Developer.SetActive(true);
    }

    void Start()
    {

       i =  PlayerPrefs.GetInt("MNo");
       ibefore = PlayerPrefs.GetInt("MNo")-1;
        Debug.Log(i);
        Debug.Log(productOwner.transform.position);
        Mission[ibefore].SetActive(false);
        Mission[i].SetActive(true);
        productOwner.SetActive(false);
        

        
        Developer.SetActive(false);
        



        if (i > 0)
        {   
            Mission[0].SetActive(false);
            
        }


        if (i == 1)
        {

            MissionTask[0].SetActive(false);
            MissionTask[1].SetActive(true);
            loadPosition();


        }
        else if (i == 2)
        {
            MissionTask[1].SetActive(false);
            MissionTask[2].SetActive(true);
            loadPosition();


        }
        else if (i == 3)
        {
            MissionTask[2].SetActive(false);
            MissionTask[3].SetActive(true);
            loadPosition();
        }
        else if (i == 4)
        {
            MissionTask[3].SetActive(false);
            MissionTask[4].SetActive(true);
            productOwner.SetActive(false);
            loadPositionDev();
            


        }
        else if (i == 5)
        {
            MissionTask[4].SetActive(false);
            MissionTask[5].SetActive(true);
            productOwner.SetActive(false);
            loadPositionDev();

        }
        else if (i == 6)
        {
            MissionTask[5].SetActive(false);
            MissionTask[6].SetActive(true);
            productOwner.SetActive(false);
            loadPositionDev();
        }
        else { }


    }

    // Update is called once per frame
    void Update()
    {
        // i = PlayerPrefs.GetInt("MNo");
        if (i >= 2)
        {
            person1.SetActive(true);
            person2.SetActive(true);
            person3.SetActive(true);
            person4.SetActive(true);
            person5.SetActive(true);
            person6.SetActive(true);
            person7.SetActive(true);
            person8.SetActive(true);
        }
        if(i>= 4)
        {
            person1.SetActive(false);
        }


    }

    void Awake()
    {
       

    }
}
