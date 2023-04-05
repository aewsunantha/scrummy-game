using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotMini : MonoBehaviour
{
    public static DoNotDestroy instance;

    private void Awake()
    {
         GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");

        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);
        
       


    }
}
