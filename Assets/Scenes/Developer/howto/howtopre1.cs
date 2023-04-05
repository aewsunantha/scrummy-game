using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howtopre1 : MonoBehaviour
{


    public GameObject next;
    public void skip()
    {
        next.SetActive(true);
    }


    public void pre1next()
    {
        SceneManager.LoadScene("premini1");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("pre1next", 10f);
        Invoke("skip", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
