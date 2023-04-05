using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DevIntro : MonoBehaviour
{
    public GameObject video1, video2;
    public string teamname;
    public Text teamnameText;
    public Text text;
    public GameObject chatbox,chatbox2;
    // Start is called before the first frame update


    public void openChatbox()
    {


        chatbox.SetActive(true);
        teamnameText.text = teamname;

    }
    public void openChatbox2()
    {


        chatbox2.SetActive(true);
        teamnameText.text = teamname;

    }

    public void DevIntroconfirm()
    {
        SceneManager.LoadScene("office");
    }
    public void finitePO()
    {
        SceneManager.LoadScene("DevIntro");
    }
    public void startM4()
    { 
        video1.SetActive(false);
        video2.SetActive(true);
        chatbox.SetActive(false);
        Invoke("openChatbox2", 1.0f);
       
    }
    public void startM4part2()
    {
        SceneManager.LoadScene("premini4");

    }
    public void endmini4()
    {
        SceneManager.LoadScene("office");
    }



    public void StartM5()
    {

        SceneManager.LoadScene("FirstSprint");

    }
    public void problem()
    {

        SceneManager.LoadScene("oneday");

    }

    public void dailyMeeting()
    {
        SceneManager.LoadScene("Daily Meeting");
    }

    public void gotointro()
    {
        SceneManager.LoadScene("Scrum Intro");
    }

    public void SprintReview()
    {

        SceneManager.LoadScene("Review intro");

    }

    public void SprintReview2()
    {

        SceneManager.LoadScene("RV");

    }


    public void finiteReview1()
    {
        SceneManager.LoadScene("Sprint Retro");

    }

    public void finiteRetro()
    {
        SceneManager.LoadScene("Mini 5 know");
        

    }
    public void onedaypart2()
    {
        SceneManager.LoadScene("oneday2");

    }



    public void finalreview()
    {

        SceneManager.LoadScene("RV2");
    }

    public void finalretro()
    {

        SceneManager.LoadScene("Sprint Retro2");
    }

    public void offer()
    {

        SceneManager.LoadScene("offer");
    }

    public void beforeoffer()
    {

        SceneManager.LoadScene("before offer");
    }

    public void allrating()
    {

        SceneManager.LoadScene("allrating");
    }


    void Start()
    {
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();

        teamname = PlayerPrefs.GetString("Teamname");
        Invoke("openChatbox", 1.0f);

        int orderprofile = PlayerPrefs.GetInt("orderprofile");
        int orderchat = PlayerPrefs.GetInt("orderchat");
        int orderregis = PlayerPrefs.GetInt("orderregis");
        int orderproduct = PlayerPrefs.GetInt("orderproduct");
        int orderpayment = PlayerPrefs.GetInt("orderpayment");
        int orderaccount = PlayerPrefs.GetInt("orderaccount");


        Debug.Log(orderprofile);
        Debug.Log(orderchat);
        Debug.Log(orderregis);
        Debug.Log(orderproduct);
        Debug.Log(orderpayment);
        Debug.Log(orderaccount);
        
       



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
