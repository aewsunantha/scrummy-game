using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Teamsetup : MonoBehaviour
{
   // private float musicVolume = 1f;
    //public AudioSource audioSource;

    public GameObject confirm;
    public string inputTeam;
    public string[] randname = {"Entaneer","CPE","Gear","ComA+","FyTy","ProjectFail","CMU","Engineer","Scrummy","LachanaTeam" };
    public Text randomTeam ,inputkey;
    public GameObject placeh;
    

    public void randtext()
    {
        randomTeam.gameObject.SetActive(true);
        int randnum = UnityEngine.Random.Range(0,10);
        inputTeam = randname[randnum];
        randomTeam.text = inputTeam;
        inputkey.gameObject.SetActive(false);
        placeh.SetActive(false);
        randomTeam.gameObject.transform.SetSiblingIndex(3);

    }

                
    public void onClickkkk()
    {   
        Debug.Log(inputTeam.ToString());
        PlayerPrefs.SetString("Teamname", inputTeam.ToString());
        SceneManager.LoadScene("introduce");
    }

    public void ReadStringInput(string s)
    {
        randomTeam.gameObject.SetActive(false);

        inputTeam = s;
       

    }
    public void INPUTTEXT()
    {

        randomTeam.gameObject.SetActive(false);
        inputkey.gameObject.SetActive(true);

    }
    // Start is called before the first frame update
    void Start()
    {
       // DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
        //musicVolume = PlayerPrefs.GetFloat("volume");
        //audioSource.volume = musicVolume;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
