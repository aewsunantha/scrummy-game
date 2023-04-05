using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject setting, settingwindow, mute;

    public void loadM5()
    {
        SceneManager.LoadScene(18);

    } 
    public void loadM4()
    {
        SceneManager.LoadScene(63);

    }

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
    public void quitgamev()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public GameObject playbutton;
    public void onClickPlayy()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("GameMode");
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    
    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
