using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject setting, settingwindow, mute;
   
    
    public void settingclick()
    {
        settingwindow.transform.SetAsLastSibling();

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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
