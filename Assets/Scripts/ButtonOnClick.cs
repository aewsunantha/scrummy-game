using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ButtonOnClick : MonoBehaviour
{

	public Button yourButton;
	public int score = 5;
	public Text passtxt;
	public Text fail1txt;
	public Text fail2txt;
	public Text fail3txt;
	public Text fail4txt;
	public Image[] heart;
	public Image bgfade;
	public Image scrum;
	public Button okay;
	public Button next;
	public bool chek;
	public string[] textErr;
	public bool check22; 
	public bool[] check222; 
	public bool check33;
	public int[] check333;
	
	public bool checkT; 
	public bool checkB;
	public string[] nicknametext;
	public string[] savenicknametext;
	public string[] checkRolltext;

	public GameObject scrumhelp;

    public void nonehelp()
    {
        scrumhelp.SetActive(false);
    }

    public void knowladge()
    {
        PlayerPrefs.SetInt("mini1", score);
        PlayerPrefs.SetInt("scDisplay", score);
        SceneManager.LoadScene("Mini 1 know");
    }


    void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		Button btn2 = okay.GetComponent<Button>();
		btn2.onClick.AddListener(Okay);

		/*Button btn3 = next.GetComponent<Button>();
		btn3.onClick.AddListener(ClickNext);
		*/
		score = 5;

		for(int i=0; i<heart.Length; i++)
        {
		heart[0].gameObject.SetActive(true);
        }
		bgfade.gameObject.SetActive(false);
		scrum.gameObject.SetActive(false);
		okay.gameObject.SetActive(false);
		next.gameObject.SetActive(false);
		passtxt.gameObject.SetActive(false);
		fail1txt.gameObject.SetActive(false);

		int oldValue = PlayerPrefs.GetInt("OldValue");
		
	}

	




	/*void ClickNext()
	{ //LoadScenc
		SceneManager.LoadScene("premini4");
		//send 
		PlayerPrefs.SetInt("mini1", score);
		

	}
	*/

	void Okay()
    {
		bgfade.gameObject.SetActive(false);
		scrum.gameObject.SetActive(false);
		okay.gameObject.SetActive(false);
		fail1txt.gameObject.SetActive(false);
		fail1txt.text = "";

		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//PlayerPrefs.SetInt("OldValue", score);
		if(check22 == true && check33 == true && checkT == true && checkB == true)
        {	
			//send 
			PlayerPrefs.SetInt("mini1", score);
            PlayerPrefs.SetInt("scDisplay", score);
			//LoadScenc
			SceneManager.LoadScene("Mini 1 know");
			passtxt.text = "";


		}
	}



void TaskOnClick()
	{

		string tempRoll = "";
		string tempText = "";







		for (int i = 0; i < check333.Length; i++)
		{
			check333[i] = LevelManager.Instance.check333[i];
			

		}

		for (int i = 0; i < LevelManager.Instance.check.Length; i++)
		{
			check222[i] = LevelManager.Instance.check[i];
		}




        for (int j = 0; j < nicknametext.Length; j++)
        {
            if (check333[j] == 2 || check333[j] == 1)
            {
                savenicknametext[j] = " ";

                //tempText += ("");
            }else
            if (check333[j] == 0)
            {
                savenicknametext[j] = nicknametext[j];
                //tempText += (" " + nicknametext[j]+ " ");

            }


        }




        Debug.Log("You have clicked the button!");
		 check22 = LevelManager.Instance.check22;
        check33 = LevelManager.Instance.check33;
       
		checkT = LevelManager.Instance.checkTime;
		checkB = LevelManager.Instance.checkBudget;
		
		if (check22 == true && check33 == true && checkT == true && checkB == true )
        {
            if (score < 1)
            {
				score = 1;
            }
			//frame.gameObject.SetActive(true);
			fail1txt.text = "";
			
			bgfade.gameObject.SetActive(true);
			scrum.gameObject.SetActive(true);
			passtxt.gameObject.SetActive(true);
			fail1txt.gameObject.SetActive(false);
			//next.gameObject.SetActive(true);
			passtxt.text = "ดีใจด้วย! ที่เล่นเกมผ่านซักที";
			
			okay.gameObject.SetActive(true);
			/*
			//LoadScenc
			SceneManager.LoadScene("premini4");
			//send 
			PlayerPrefs.SetInt("mini1", score);
			*/

		}
		else 
        {
			bgfade.gameObject.SetActive(true);
			scrum.gameObject.SetActive(true);
			okay.gameObject.SetActive(true);
			fail1txt.gameObject.SetActive(true);

			passtxt.gameObject.SetActive(false);
			//LevelManager.Instance.movefirst();
			score--;
			
			
			
			if (score < 1)
			{
				score = 1;
				scrumhelp.SetActive(true);

			}
			heart[score].gameObject.SetActive(false);
			passtxt.text = "";



			if (check22 == false)
			{
				
				for (int i = 0; i < LevelManager.Instance.check.Length; i++)
				{
					if (LevelManager.Instance.check[i] == false)
					{
						tempRoll += " " + checkRolltext[i];


					}
				}
				fail1txt.text += "ทีมของคุณยังขาดตำแหน่ง "+tempRoll+"\n";
			}
            else
            {
				fail1txt.text += "";

			}



			tempText = "";

            if (check33 == false)
			{
				

                for (int j = 0; j < nicknametext.Length; j++)
                {
					if (savenicknametext[j].Length > 0)
					{
						tempText +=  savenicknametext[j];
					}
					
                }

                fail1txt.text += "สกิลของ" + tempText + "ยังไม่เหมาะสมกับตำแหน่ง\n";

			}
			else
            {
                
                fail1txt.text += "";

			}




			if (checkT == false)
			{
				fail1txt.text += "เวลาส่งมอบยังเกิน 8 เดือน\n";

            }
            else
            {
				fail1txt.text += "";
			}

			if (checkB == false)
			{
				fail1txt.text += "ใช้งบประมาณเกินกำหนด";

			}
            else
            {
				fail1txt.text += "";

			}
			


		}

	}
}
