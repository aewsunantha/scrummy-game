using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicBGmini : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject ObjectMusic;
    public float musicVolume = 1f;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        ObjectMusic = GameObject.FindWithTag("GameMusicMini");
        audioSource = ObjectMusic.GetComponent<AudioSource>();

        //Set Volume
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;



        int x = SceneManager.GetActiveScene().buildIndex + 1;

        Debug.Log("x = " + x);

        //int o = SceneManager.GetActiveScene().buildIndex;


        /*if (x == 28)
        {
            Debug.Log("3");
            DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
            
            MusicReset();
        }*/
        /*
        if (x == 28)
        {   MusicUnMute();
            DoNotDestroy2.instance.GetComponent<AudioSource>().Play();
           
        }
        if (x == 37)
        {
            DoNotDestroy2.instance.GetComponent<AudioSource>().Play();
            MusicUnMute();
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
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
