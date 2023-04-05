using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    public static DoNotDestroy instance;
    /*private void Awake()
     {

          GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");




         if(musicObj.Length > 1)
         {
             Destroy(this.gameObject);

         }
         DontDestroyOnLoad(this.gameObject);







     }
    */
 
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


    // Start is called before the first frame update

}
