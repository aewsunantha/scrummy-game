using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howto1 : MonoBehaviour

{   public GameObject next;
   
    public void next1()
    {
        SceneManager.LoadScene("minigame1");
    }

    public void skip()
    {
        next.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 14f);
        Invoke("skip", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
