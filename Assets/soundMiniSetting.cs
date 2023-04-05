using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundMiniSetting : MonoBehaviour
{

    public static soundMiniSetting instance;

    public float musicVolume = 1f;
    public AudioSource audioSource;
    public Slider volumeSlider;



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




    // Start is called before the first frame update
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume; 
        volumeSlider.value = musicVolume;
        DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
       




    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);

    }
}
