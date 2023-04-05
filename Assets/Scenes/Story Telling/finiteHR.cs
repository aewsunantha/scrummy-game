using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class finiteHR : MonoBehaviour
{

    public string teamname;
    public Text teamnameText;
    public Text text;
    public GameObject chatbox;
    // Start is called before the first frame update


    public void openChatbox()
    {


        chatbox.SetActive(true);
        teamnameText.text = teamname;

    }
    public void onClickk()
    {
        SceneManager.LoadScene("office");
    }

    public void confirmclick()
    {
        SceneManager.LoadScene("Howto 2");
    }

    void Start()
    {
        

        teamname = PlayerPrefs.GetString("Teamname");
        Invoke("openChatbox", 1.0f);
        DoNotDestroy.instance.GetComponent<AudioSource>().Play();




    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
