using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{

    public Slider volumeSlider;
    public GameObject ObjectMusic;
    public float musicVolume = 1f;
    private AudioSource audioSource;
    // public AudioSource audioSource_2;

    public int x;


    private void Start()
    {
       
        //PlayerPrefs.SetFloat("volume", 1);
        ObjectMusic = GameObject.FindWithTag("GameMusic");
        audioSource = ObjectMusic.GetComponent<AudioSource>();
       // audioSource_2 = ObjectMusic.GetComponent<AudioSource>();

        //Set Volume
        musicVolume = PlayerPrefs.GetFloat("volume");
        
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;


        
        int x = SceneManager.GetActiveScene().buildIndex + 1;

        Debug.Log("x " + x);
        
        int o = SceneManager.GetActiveScene().buildIndex;
       

        if (x == 1)
        {
            /*Debug.Log("3");
            DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
            */
            MusicReset();
        }

     


    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);

        /*
        if (x == 60)
        {
            musicVolume = PlayerPrefs.GetFloat("volume2");
            audioSource.volume = musicVolume;
            volumeSlider.value = musicVolume;

        }
        */
        


        // if (Input.GetKeyDown(KeyCode.Space))
        // {

        //if (SceneManager.GetActiveScene().name == "GameMode") { DoNotDestroy.instance.GetComponent<AudioSource>().Pause(); }

        //BGmusic.instance.GetComponent<AudioSource>().Play();



    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
   
    public void MusicReset()
    {
        PlayerPrefs.DeleteKey("volume");
        audioSource.volume = 1;
        volumeSlider.value = 1;
    } 
    public void MusicMute()
    {
        PlayerPrefs.SetFloat("curvol", musicVolume);
        PlayerPrefs.DeleteKey("volume");
        //audioSource.mute;
        audioSource.volume = 0;
        volumeSlider.value = 0;
    } 
    public void MusicUnMute()
    {
        float curvol = PlayerPrefs.GetFloat("curvol");
        PlayerPrefs.DeleteKey("volume");
        audioSource.volume = curvol;
        volumeSlider.value = curvol;

    }
}
