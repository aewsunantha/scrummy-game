using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProjectRequirement : MonoBehaviour
{
    public GameObject chatbox;
    public GameObject proJect , confirm;
    public Text text;
    public void openChatbox()
    {


        chatbox.SetActive(true);
       
        

    }
    public void openProject()
    {
        chatbox.SetActive(false);
        proJect.SetActive(true);
        confirm.SetActive(true);
    }

    public void confirmclick()
    {
        SceneManager.LoadScene("BeforeHR");
    }

   

    // Start is called before the first frame update
    void Start()
    {
        Invoke("openChatbox", 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
