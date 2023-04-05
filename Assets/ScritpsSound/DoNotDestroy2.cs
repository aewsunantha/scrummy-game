using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy2 : MonoBehaviour
{
    public static DoNotDestroy2 instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
