using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howtowalk : MonoBehaviour
{
    public GameObject next;
    public void skip()
    {
        next.SetActive(true);
    }
    public void next1()
    {
        SceneManager.LoadScene("office");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 8f);
        Invoke("skip", 2f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
