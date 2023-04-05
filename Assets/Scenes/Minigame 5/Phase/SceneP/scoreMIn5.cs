using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class scoreMIn5 : MonoBehaviour
{
    public int[] min5score = new int[4];
    public int avg ,sum;

   
    public void avgmin5()
    {
         sum = min5score[0]+ min5score[1]+ min5score[2]+ min5score[3];
        avg = sum / min5score.Length;
        PlayerPrefs.SetInt("scDisplay", avg);
        PlayerPrefs.SetInt("mini5", avg);

    }


    // Start is called before the first frame update
    void Start()
    {
       min5score[0] = PlayerPrefs.GetInt("min5require");
       min5score[1] = PlayerPrefs.GetInt("min5Design");
       min5score[2] = PlayerPrefs.GetInt("min5test");
       min5score[3] = PlayerPrefs.GetInt("min5Dev");

        avgmin5();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
