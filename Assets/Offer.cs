using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Offer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject setting, settingwindow, mute;
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
            Debug.Log("tag");
            SceneManager.LoadScene("allrating");


        }
    }

            void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
